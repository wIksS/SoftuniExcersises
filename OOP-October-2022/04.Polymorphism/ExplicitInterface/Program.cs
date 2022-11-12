using System;

namespace ExplicitInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDrawer drawer = new Drawer();
            IModernDrawer modernDrawer = new Drawer();

            drawer.Draw();
            modernDrawer.Draw();
        }
    }

    interface IDrawer
    {
        int this[int x] { get; set; }

        event EventHandler<int> Changed;

        void Draw();
    }

    interface IModernDrawer
    {
        void Draw();
    }

    class Drawer: IDrawer, IModernDrawer
    {
        private int index = 0;
        public int this[int x] { get => index; set => index = x; }

        public Drawer()
        {
           
        }

        event EventHandler<int> IDrawer.Changed
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        void IDrawer.Draw()
        {
            Console.WriteLine("Drawing");
        }

        void IModernDrawer.Draw()
        {
            Console.WriteLine("Modern Drawing");
        }
    }
}
