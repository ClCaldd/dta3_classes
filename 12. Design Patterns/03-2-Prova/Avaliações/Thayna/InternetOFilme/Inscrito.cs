public class Inscrito : IInscrito
{
    public void Update()
    {
        var i = Random.Shared.Next(1,3);
        if(i == 1)
            Console.WriteLine("Muito Vanilla");
        else
            Console.WriteLine("MUA HA HA HA!!! GORE");
    }
}