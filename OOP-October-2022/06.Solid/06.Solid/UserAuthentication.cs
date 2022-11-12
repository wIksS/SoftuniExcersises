using System;
using System.Collections.Generic;
using System.Text;

namespace _06.Solid
{
    public class UserAuthentication
    {
        public void Register(string email, string password)
        {
            //50 lines of email validation
            throw new ArgumentException("Email is not a valid email");

            // 500 lines of code
            // check if password is valid as per our reqs
            // check in online databases if password compromised
            throw new ArgumentException("Password must contain six symbols");

            //add new user to database
        }

        public void GetReportForAllUsers()
        {
            // 300 lines of code
            // get all users
            // construct a report for their usage data
        }
    }
}
