namespace ConsoleApp.ClassesDemo
{
    public class Rectangle : Polygon 
    {
        public int Length { get; set; }

        public Rectangle(int width, int length)
        {
            Length = length;
            Width = width;
        }
        public override int Area()
        {
            return Length * Width;        
        }
    }
}
