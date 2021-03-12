namespace P02._DrawingShape_Before
{
    using Contracts;
    using P02._DrawingShape_Before.Drawers;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    class DrawingManager
    {
        private List<IDrawer> drawers;
        //= new List<IDrawer>()
        //{
        //    new CircleDrawer(),
        //    new RectangleDrawer(),
        //    new TriangleDrawer(),
        //    new PlayerDrawer(),
        //    new LineDrawer()
        //};

        public DrawingManager()
        {
            drawers = new List<IDrawer>();
            var types= Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(IDrawer).IsAssignableFrom(t) &&
                typeof(IDrawer) != t)
                .ToList();

            foreach (var type in types)
            {
                drawers.Add((IDrawer)Activator.CreateInstance(type));
            }
        }

        public void Draw(IShape shape)
        {
            var drawer = drawers.First(d => d.IsMatch(shape));
            drawer.Draw(shape);
        }
    }
}
