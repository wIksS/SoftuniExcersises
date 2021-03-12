using System;
using System.Collections.Generic;
using System.Text;

namespace P02._Identity_Before.Contracts
{
    public interface IAccountAuthentication
    {
        void Register(string username, string password);

        void Login(string username, string password);

        void ChangePassword(string oldPass, string newPass);
    }
}
