using System;

namespace Practice
{
    // Класс Shape
    public class Shape
    {
        // Свойства (Properties)
        public double Length { get; set; }
        public double Width { get; set; }

        public double Audany { get; set; }

        // Default constructor (Конструктор по умолчанию / пустой конструктор)
        public Shape()
        {
            
        }

        // Перегрузка конструктора с двумя параметрами
        public Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }

        // Метод для нахождения площади
        public double Square()
        {
            Audany = Length * Width;
            return Audany;
        }

        public void SquareConsole()
        {
            Audany = Length * Width;
            Console.WriteLine(Audany);
        }

    }
}
