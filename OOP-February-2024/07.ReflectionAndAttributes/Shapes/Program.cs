

using Shapes;
using System.Reflection;

Type[] types = Assembly.GetExecutingAssembly().GetTypes();

Type[] shapeTypes = types.Where(t => t.IsAssignableTo(typeof(Shape)) && t.Name != "Shape").ToArray();

List<Shape> shapes = new List<Shape>();

foreach (Type type in shapeTypes)
{
    shapes.Add((Shape)Activator.CreateInstance(type));
}

foreach (Shape shape in shapes)
{
    shape.Draw();
}