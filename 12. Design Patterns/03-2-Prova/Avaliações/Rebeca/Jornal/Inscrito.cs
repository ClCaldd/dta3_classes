public class Inscrito(string _tipo) : IInscrito
{
    string Tipo = _tipo;
    public void Update(string tipo)
    {
        Console.WriteLine("Livro de " + tipo + " entregue");   
    }
}