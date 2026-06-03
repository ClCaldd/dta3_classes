public class Assintate : IAssinante
{
    public void Update()
    {
        var i = Random.Shared.Next(1,3);
        if(i == 1)
            Console.WriteLine("Não pegou");
        else
            Console.WriteLine("Pegou");
    }

}