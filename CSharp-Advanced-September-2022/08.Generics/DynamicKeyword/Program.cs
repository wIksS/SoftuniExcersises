using System;

namespace DynamicKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object x = null;
            int num = 5;

            string number = "5";
            dynamic obj = number;
            obj = DateTime.Now;

            int result = obj.hello.helloagain.fdsf.dsf.dsf.dsf.s.df.sd.f.sd.fsd.f.ds.f.d.fs.df.d.s.f.ds.fsd;

            DateTime dateAfter5Days = obj.AddDays(5);



            Console.WriteLine(dateAfter5Days);
        }
    }
}
