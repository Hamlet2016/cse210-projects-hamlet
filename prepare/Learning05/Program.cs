using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        // Crear instancias de Square, Rectangle y Circle
        Square square = new Square("Red", 5);
        Rectangle rectangle = new Rectangle("Blue", 4, 6);
        Circle circle = new Circle("Green", 3);

        // Agregar las formas a la lista
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        // Iterar a través de la lista y mostrar el color y el área de cada forma
        foreach (Shape shape in shapes)
        {
            Console.WriteLine("Color: " + shape.Color);
            Console.WriteLine("Área: " + shape.GetArea());
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}