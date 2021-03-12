namespace P02._Identity_Before.Contracts
{
    public interface IUser
    {
        string Email { get; }

        string PasswordHash { get; }
    }
}
