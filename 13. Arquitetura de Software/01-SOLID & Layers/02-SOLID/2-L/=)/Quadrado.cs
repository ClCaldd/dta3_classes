public class Square(double s) : IFormaGeometrica
{
    public double Size { get;set; } = s;

    public double Area() => Size*Size;
}