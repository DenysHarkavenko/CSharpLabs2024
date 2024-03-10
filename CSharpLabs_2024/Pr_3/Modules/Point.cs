namespace Pr_3.Modules
{
    internal class Point
    {
        public int X { get; }
        public int Y { get; }
        public string Name { get; }

        public Point(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }
    }
}
