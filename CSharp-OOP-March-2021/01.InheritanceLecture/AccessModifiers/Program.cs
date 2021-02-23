using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Base baseObject = new Base();
            baseObject.BaseMethod();

            Child child = new Child();

            child.BaseMethod();
        }
    }
}
