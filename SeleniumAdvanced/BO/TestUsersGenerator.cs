using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvanced.BO
{
    class TestUsersGenerator
    {
        public static User GenerateValidUser()
        {
            return new User("admin", "admin");
        }

        public static User GenerateInvalidUser()
        {
            return new User("admin1", "admin1");
        }
    }
}
