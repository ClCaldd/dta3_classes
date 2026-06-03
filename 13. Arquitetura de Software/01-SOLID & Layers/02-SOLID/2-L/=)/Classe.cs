using System.Drawing;
using System.Formats.Asn1;

public static class Classe
{
    public static void AgirComFormaGeometrica(IFormaGeometrica forma)
    {
        var area = forma.Area();
        Console.WriteLine(area);
    }
    
    public static void AgirEspecificamenteComRetangulo(Rectangle rec)
    {
        rec.Altura = 8;
        rec.Largura = 5;

        var area = rec.Altura * rec.Largura; // Em teoria deveria vir 40
        Console.WriteLine(area); // Vai retornar 40
    }
}