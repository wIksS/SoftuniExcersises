namespace P02._DrawingShape_Before.Contracts
{
    interface IDrawer
    {
        void Draw(IShape shape);

        bool IsMatch(IShape shape);
    }
}
