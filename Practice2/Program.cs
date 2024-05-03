
using System;

namespace Practice2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Rectangle rectangle = new Rectangle();
            //rectangle.Width = 15;
            //rectangle.Length = 78;

            //Console.WriteLine("Rectangle var:");
            //Console.WriteLine(rectangle.Square());

            Shape rectangle = new Rectangle(15, 20);

            Shape triangle = new Triangle()
            {
                Side1 = 2,
                Side2 = 5,
                Side3 = 10
            };

            Shape circle = new Circle()
            {
                Radius = 10
            };

            //Console.WriteLine("Rectangle:");
            //Console.WriteLine(rectangle.Square());

            //Console.WriteLine("Triangle:");
            //Console.WriteLine(triangle.Square());

            //Console.WriteLine("Circle:");
            //Console.WriteLine(circle.Square());

            Shape[] allShapes = new Shape[] { rectangle, triangle, circle };

            foreach(Shape shape in allShapes)
            {
                Console.WriteLine(shape.ToString());
                Console.WriteLine(shape.Square());
            }
            
            ////////////////////////////////////////////////////////////////////////////

            Rectangle rectangle2 = new Rectangle(20, 40);

            Console.WriteLine("Площадь перед изменением длины: ");
            Console.WriteLine(rectangle2.Square());

            Console.Write("Введите длину прямоугольника: ");
            var userLength = Console.ReadLine();

            rectangle2.SetLength(double.Parse(userLength));


            Console.WriteLine("Площадь после изменения длины: ");
            Console.WriteLine(rectangle2.Square());

            // Төмендегі екі строка қатені көрсетеді
            // Инкапсуляция бойынша оларға мән жазуға болмайды
            // Себебі set => protected немесе private
            //rectangle2.Width = 20;
            //rectangle2.Length = 40;

        }
    }
}