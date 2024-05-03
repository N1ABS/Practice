namespace Practice2
{

    public class Rectangle : Shape
    {
        public double Length { get; private set; }
        public double Width { get; protected set; }

        public Rectangle()
        {
            
        }

        public void SetLength(double otherLength)
        {
            if (otherLength > 0) 
                Length = otherLength;

            return;
        }

        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }

        public override double Square()
        {
            return Length * Width;
        }

        public override string ToString()
        {
            return "This is a rectangle: ";
        }

    }
}