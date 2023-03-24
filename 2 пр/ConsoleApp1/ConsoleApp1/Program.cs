using System;

public class PR2
{
    private double a;
    private double b;
    private double c;
    private double x1;
    private double x2;

    public PR2(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    private double CalculateDiscriminant()
    {
        return b * b - 4 * a * c;
    }

    public void CalculateRoots()
    {
        double discriminant = CalculateDiscriminant();

        if (discriminant < 0)
        {
            Console.WriteLine("Ответ: корней нет");
        }
        else if (discriminant == 0)
        {
            x1 = -b / (2 * a);
            Console.WriteLine($"Ответ: один корень: x = {x1}");
        }
        else
        {
            x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Ответ: два корня: x1 = {x1}, x2 = {x2}");
        }
    }
}
class Program
{
    static void Main()
    {
        PR2 equation = new PR2(3, 2, 1);
        equation.CalculateRoots();
    }
}
