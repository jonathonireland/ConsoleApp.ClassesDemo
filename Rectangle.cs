namespace ConsoleApp.ClassesDemo
{
    public class Rectangle : Polygon, I2DShape 
    {
        public double Length { get; set; }

        public Rectangle(double width, double length)
        {
            Length = length;
            Width = width;
        }
        public override double Area()
        {
            return (double)(Length * Width);        
        }

        public double Perimeter()
        {
            return (2 * Length) + (2 * Width);
        }

        double I2DShape.Perimeter()
        {
            throw new NotImplementedException();
        }
    }
}
