using System;

namespace SingleResponsibilityAfter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Whats your email");
                string email = Console.ReadLine();
                Console.WriteLine("Whats your password?");
                string password = Console.ReadLine();

                EmailValidator emailValidator = new EmailValidator();
                PasswordValidator passwordValidator = new PasswordValidator();
                UserAuthentication auth = new UserAuthentication();

                if (emailValidator.Validate(email) && passwordValidator.Validate(password))
                {
                    auth.Register(email, password);
                }
                else
                {
                    Console.WriteLine("Try again");
                    continue;

                }

                UserReports reports = new UserReports();

                reports.GetAllUsers();
            }

        }
    }
}
