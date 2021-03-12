namespace P01._DrawingShape_Before
{
    using Contracts;

    public class DrawingManager : IDrawingManager
    {
        private readonly IDrawingContext drawingContext;
        private readonly IRenderer renderer;

        public DrawingManager(IDrawingContext drawingContext, IRenderer renderer)
        {
            this.drawingContext = drawingContext;
            this.renderer = renderer;
        }

        public void Draw(IShape shape)
        {
            renderer.Render(drawingContext, shape);           
        }
    }
}
