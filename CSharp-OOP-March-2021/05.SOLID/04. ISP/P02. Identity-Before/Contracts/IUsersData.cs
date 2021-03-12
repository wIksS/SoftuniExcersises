using System;
using System.Collections.Generic;
using System.Text;

namespace P02._Identity_Before.Contracts
{
    interface IUsersData
    {
        IEnumerable<IUser> GetAllUsersOnline();

        IEnumerable<IUser> GetAllUsers();

        IUser GetUserByName(string name);
    }
}
