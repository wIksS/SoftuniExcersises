using System.Reflection;

namespace AuthorProblem
{
    [Author("Dimitrichko")]
    [Author("Dimitrichka")]
    public static class StartUp
    {
        [Author("Gogi")]
        public static void Main(string[] args)
        {

            Type type = typeof(StartUp);

            foreach (var method in type.GetMethods((BindingFlags)60))
            {
                AuthorAttribute[] attributes = method.GetCustomAttributes<AuthorAttribute>().ToArray();

                foreach (var attr in attributes)
                {
                    Console.WriteLine($"{method.Name} is written by {attr.Name}");
                }
            }
        }

        
        [Author("AUthor")]
        public static void OtherMethod()
        {

        }
    }
}