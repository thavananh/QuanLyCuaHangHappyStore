using System;
using Microsoft.Win32;

/*
 ____   ___  _____ _______        ___    ____  _____ 
/ ___| / _ \|  ___|_   _\ \      / / \  |  _ \| ____|
\___ \| | | | |_    | |  \ \ /\ / / _ \ | |_) |  _|  
 ___) | |_| |  _|   | |   \ V  V / ___ \|  _ <| |___ 
|____/ \___/|_|__ __|_|  _ \_/\_/_/   \_\_| \_\_____|
/ ___|| | | / ___|_   _|/ \  |_ _| \ | |             
\___ \| | | \___ \ | | / _ \  | ||  \| |             
 ___) | |_| |___) || |/ ___ \ | || |\  |             
|____/ \___/|____/ |_/_/   \_\___|_| \_|     

DEVELOPED AND MAINTAINED BY SOFTWARE SUSTAIN
*/

namespace BLL
{
    public class FirstRunChecker
    {
        private const string RegistryKeyPath = @"SOFTWARE\QuanLyCuaHangHappyStore";
        private const string FirstRunValueName = "IsFirstRun";
        private const string PasswordValueName = "SpecialPassword";
        public static string userSpecialPass = "null";

        public static bool IsFirstRun()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryKeyPath))
            {
                if (key == null || key.GetValue(FirstRunValueName) == null)
                {
                    SetFirstRun();
                    return true;
                }
                return false;
            }
        }

        private static void SetFirstRun()
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(RegistryKeyPath))
            {
                key.SetValue(FirstRunValueName, "No");

                // Tạo và lưu mật khẩu đặc biệt
                string specialPassword = GenerateSpecialPassword();
                userSpecialPass = specialPassword;
                string encryptPass = BCrypt.Net.BCrypt.HashPassword(specialPassword);
                key.SetValue(PasswordValueName, encryptPass);
                // Hiển thị mật khẩu đặc biệt cho người dùng
            }
        }

        private static string GenerateSpecialPassword()
        {
            // Tạo mật khẩu đặc biệt, ví dụ: random 12 ký tự
            return Guid.NewGuid().ToString().Substring(0, 12);
        }

        public static void RemoveFirstRunFlag()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryKeyPath, true))
            {
                if (key != null)
                {
                    key.DeleteValue(FirstRunValueName, false);
                    key.DeleteValue(PasswordValueName, false);
                }
            }
        }

        public static string GetSpecialPassword()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryKeyPath))
            {
                if (key != null)
                {
                    return key.GetValue(PasswordValueName)?.ToString();
                }
                return null;
            }
        }

    }
}
