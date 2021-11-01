using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3._2
{
    public class User
    {
        string name;
        string login;
        string password;

        public string Name
        {
            get => name;
        }

        public string Login
        {
            get => login;
        }

        public string Password
        {
            get => password;
        }

        public User(string name, string login, string password)
        {
            this.name = name;
            this.login = login;
            this.password = password;
        }
    }
}
