namespace UniversityCompetition.IO
{
    using System;
    using UniversityCompetition.IO.Contracts;

    public class Reader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
