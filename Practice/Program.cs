using Practice;
using System;


// создание объекта в конструктором по умолчанию
var pryamougolnik = new Shape();

// setting of values
pryamougolnik.Length = 10;
pryamougolnik.Width = 5;

// run Square method
var ploshad1 = pryamougolnik.Square();


// show output
Console.WriteLine(ploshad1);
Console.WriteLine(pryamougolnik.Audany);

// создание объекта через перегруженный конструктор
var kvadrat = new Shape(7, 7);


// run Square method
var ploshad2 = kvadrat.Square();

//show output
Console.WriteLine(ploshad2);
Console.WriteLine(kvadrat.Length);
Console.WriteLine(kvadrat.Width);


// Бүгінгі сабақта:

// Classes and Objects
// Constructors
// Methods
// Data types


// Келесі сабақта:

// Abstract classes
// Interfaces
// Virtual methods
// Overridded methods

// Наследование
// Инкапсуляция
// Полиморфизм