using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Auth
{
    internal class Authenticator
    {
        private Dictionary<string, string> users = new Dictionary<string, string>();

        public bool Register(string username, string password)
        {
            if (password.Length < 6)
            {
                throw new ArgumentException("Password cannot be less than 6 symbols");
            }
            if (username.Length < 3)
            {
                throw new ArgumentException("Username cannot be less than 3 symbols");
            }
            if (username.Any(x=> !Char.IsLetterOrDigit(x)))
            {
                throw new ArgumentException("Username can only contain letters or digits");
            }

            users.Add(username, password);

            // very bad
            throw new UserRegisteredException();
        }

        public bool Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Username or Password is empty");
            }

            return users.ContainsKey(username) && users[username] == password;
        }
    }
}
