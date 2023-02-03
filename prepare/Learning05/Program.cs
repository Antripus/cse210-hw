using System;

class Program
{
    static void Main(string[] args)
    {
        string color = "green";
        double lenght = 10;
        double width = 20;
        double radius = 15.25;

        Console.WriteLine ("");
        Console.WriteLine ("Shapes como atributos");
        Console.WriteLine ("");
        
        Shape square = new Square(color, lenght);
        Shape rectangle = new Rectangle(color, lenght,width);
        Shape circle = new Circle(color, radius);

        double squareArea = square.getArea();
        double rectangleArea = rectangle.getArea();
        double circleArea = circle.getArea();

        Console.WriteLine ($"Square Area: {squareArea}");
        Console.WriteLine ($"Rectangle Area: {rectangleArea}");
        Console.WriteLine ($"Circle Area: {circleArea}");


        Console.WriteLine ("");
        Console.WriteLine ("Shapes en Lista de Shapes");
        Console.WriteLine ("");

        // LIST DE SHAPES
        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("Blue", 5);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("Purple", 10, 20);
        shapes.Add(shape2);

        Circle shape3 = new Circle("Pink", 3.3);
        shapes.Add(shape3);

        foreach (Shape s in shapes)
        {
            string colorShape = s.getColor(); //mismo metodo para todas las shapes diferentes usa el get del padre

            double area = s.getArea(); // mismo metodo declarado pero funcionamiento distinto dependiendo el shape
            
            Console.WriteLine($"The {colorShape} shape has an area of {area}.");
        }
        Console.WriteLine ("");
    }
}