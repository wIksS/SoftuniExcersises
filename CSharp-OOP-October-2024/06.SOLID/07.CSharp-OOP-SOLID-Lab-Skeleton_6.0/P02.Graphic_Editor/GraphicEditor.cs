using System;

namespace P02.Graphic_Editor
{
    public class GraphicEditor
    {
        public void DrawShape(IShape shape)
        {
            shape.Draw();
        }
    }
}
