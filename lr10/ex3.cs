using System;

public class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public void Display()
    {
        Console.WriteLine($"Точка с координатами: ({X}, {Y})");
    }
}

public class Circle : Point
{
    public double Radius { get; set; }

    public Circle(double x, double y, double radius) : base(x, y)
    {
        if (radius < 0)
            throw new ArgumentException("Радиус не может быть отрицательным.");
        Radius = radius;
    }

    public new void Display()
    {
        Console.WriteLine($"Окружность с центром в точке ({X}, {Y}) и радиусом {Radius}");
    }
}

public class Ring : Circle
{
    public double InnerRadius { get; set; }

    public Ring(double x, double y, double radius, double innerRadius) : base(x, y, radius)
    {
        if (innerRadius < 0 || innerRadius > radius)
            throw new ArgumentException("Недопустимое значение внутреннего радиуса.");
        InnerRadius = innerRadius;
    }

    public new void Display()
    {
        Console.WriteLine($"Кольцо с центром в точке ({X}, {Y}), внешним радиусом {Radius} и внутренним радиусом {InnerRadius}");
    }
}

public class Ellipse : Point
{
    public double MajorAxis { get; set; }
    public double MinorAxis { get; set; }

    public Ellipse(double x, double y, double majorAxis, double minorAxis) : base(x, y)
    {
        if (majorAxis < 0 || minorAxis < 0)
            throw new ArgumentException("Оси не могут быть отрицательными.");
        MajorAxis = majorAxis;
        MinorAxis = minorAxis;
    }

    public new void Display()
    {
        Console.WriteLine($"Эллипс с центром в точке ({X}, {Y}), большой осью {MajorAxis} и малой осью {MinorAxis}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var point = new Point(1, 2);
        point.Display();

        var circle = new Circle(3, 4, 5);
        circle.Display();

        var ring = new Ring(6, 7, 8, 2);
        ring.Display();

        var ellipse = new Ellipse(9, 10, 11, 12);
        ellipse.Display();
    }
}