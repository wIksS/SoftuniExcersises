namespace P01._DrawingShape_Before.Contracts
{
    public interface IShape
    {
        void Draw(IRenderer renderer, IDrawingContext drawingContext);
    }
}