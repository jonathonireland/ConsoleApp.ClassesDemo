namespace ConsoleApp.ClassesDemo
{
    public class Triangle : Polygon
    {
        private int height;

        public int Width { get; private set; }
        public int Length { get; set; }

        public Triangle(int width, int length)
        {
            Width = width;
            Length = length;
        }

        public override int Area()
        {
            var wholeArea = Width * Length;
            
            return wholeArea / 2;
        }
    }
}
