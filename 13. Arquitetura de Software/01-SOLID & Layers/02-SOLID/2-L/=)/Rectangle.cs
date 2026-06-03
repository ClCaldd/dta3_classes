public class Rectangle(double l, double a) : IFormaGeometrica
{
    public double Largura { get;set; } = l;
    public double Altura { get;set; } = a;

    public double Area() => Largura * Altura;
}