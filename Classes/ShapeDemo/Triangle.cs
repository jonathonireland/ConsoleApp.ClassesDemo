namespace ConsoleApp.ClassesDemo.Classes.ShapeDemo
{
    public class Triangle : Polygon
    {
        private int height;

        public double Width { get; private set; }
        public double Length { get; set; }

        public Triangle(double width, double length)
        {
            Width = width;
            Length = length;
        }

        public override double Area()
        {
            var wholeArea = Width * Length;

            return wholeArea / 2;
        }
    }
}
