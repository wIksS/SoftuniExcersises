using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityAfter
{
    internal class UserAuthentication
    {
        private EmailValidator emailValidator;
        private PasswordValidator passwordValidator;

        public UserAuthentication()
        {
            emailValidator = new EmailValidator();
            passwordValidator = new PasswordValidator();
        }

        public void Register(string email, string password)
        {
            if (!emailValidator.Validate(email))
            {
                throw new ArgumentException("");
            }
            if (!passwordValidator.Validate(password))
            {
                throw new ArgumentException("");
            }


            User user = new User();
            //20 lines to register user to database
        }

        public void Login(string email, string password)
        {

        }
    }
}
