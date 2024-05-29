namespace NauticalCatchChallenge.IO.Contracts
{
    public interface IWriter
    {
        void Write(string message);

        void WriteLine(string message);

        void WriteText(string message);
    }
}
