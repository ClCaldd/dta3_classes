using System.Drawing;
using System.Formats.Asn1;

public static class Classe
{
    public static void AgirEspecificamenteComRetangulo(Rectangle rec)
    {
        rec.Altura = 8;
        rec.Largura = 5;

        var area = rec.Altura * rec.Largura; // Em teoria deveria vir 40
        Console.WriteLine(area); // Vai retornar 25, uma vez que ao definir Largura também defino Altura
    }
}