using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvanced.BO
{
    class User
    {
        public User(String login, String password)
        {
            this.login = login;
            this.password = password;
        }

        private String login;
        private String password;

        public String getLogin()
        {
            return login;
        }

        public String getPassword()
        {
            return password;
        }
    }
}
