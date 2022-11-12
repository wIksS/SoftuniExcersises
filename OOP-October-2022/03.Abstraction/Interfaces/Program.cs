using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var doc = new Document();

            IPrintable printable = doc;
            I3DPrintable printable3D = doc;

            IDisposable disposable = doc;

            Passport passport = new Passport();

            IPrintable printablePassport = passport;
        }
    }
}
