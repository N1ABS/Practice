using System;
namespace Practice2
{
    public class Triangle : Shape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public override double Square()
        {
            var perimeter = Side1 + Side2 + Side3;

            return Math.Sqrt(perimeter * 
                (perimeter - Side1) * 
                (perimeter - Side2) * 
                (perimeter - Side3));
        }
    }
}


/* 
 public
 protected
 private
 internal
 */