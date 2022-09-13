namespace Gyms
{
    public class Athlete
    {
        public Athlete(string fullName)
        {
            this.FullName = fullName;
            this.IsInjured = false;
        }

        public string FullName { get; set; }

        public bool IsInjured { get; set; }
    }
}
