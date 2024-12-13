using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class Ultility
    {
        public static string HashPassword(string password)
        {
            string cyper = BCrypt.Net.BCrypt.HashPassword(password);
            return cyper;
        }
    }
}
