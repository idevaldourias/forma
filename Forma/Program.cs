using Forma.Entities;
using Forma.Enums;

IShape rectangle = new Rectangle { Height = 2.5, Width = 3.5, Color = Color.White };
IShape circle = new Circle { Color = Color.Black, Radius = 4 };

Console.WriteLine(rectangle);
Console.WriteLine(circle);