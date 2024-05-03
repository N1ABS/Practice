using System;
namespace Practice2
{
    public class Circle : Shape
    { 
        public double Radius { get; set; }

        //public override double Square()
        //{
        //    return Math.PI * Math.Pow(Radius, 2);
        //}
        public override string ToString()
        {
            return "This is a circle: ";
        }
    }
}


/* 
 public
 protected
 private
 internal
 */