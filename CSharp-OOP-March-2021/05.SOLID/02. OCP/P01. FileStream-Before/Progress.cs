namespace P01._FileStream_Before
{
    public class Progress
    {
        private readonly IProgressable prograssable;

        public Progress(IProgressable prograssable)
        {
            this.prograssable = prograssable;
        }

        public int CurrentPercent()
        {
            return this.prograssable.Sent * 100 / this.prograssable.Length;
        }
    }
}
