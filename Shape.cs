public abstract class Shape
{
    public abstract double GetArea();
    public void Describe() 
    {
        Console.WriteLine("This is a shape");

    }

}

public class Circle : Shape 
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double GetArea()
    {

        return radius * radius * 3.14;

    }
}

public class Square : Shape 
{
    private double side;
    public Square(double side)
        { this.side = side; }
    public override double GetArea() { return side * side; }
}