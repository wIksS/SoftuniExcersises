namespace P01._DrawingShape_Before.Contracts
{
    public interface IRenderer
    {
        void Render(IDrawingContext context, IShape shape);
    }
}