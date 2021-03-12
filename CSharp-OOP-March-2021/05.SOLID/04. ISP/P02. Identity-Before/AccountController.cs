namespace P02._Identity_Before
{
    using Contracts;

    public class AccountController
    {
        private readonly IAccountAuthentication manager;

        public AccountController(IAccountAuthentication manager)
        {
            this.manager = manager;
        }

        public void ChangePassword(string oldPass, string newPass)
        {
            this.manager.ChangePassword(oldPass, newPass);
        }
    }
}
