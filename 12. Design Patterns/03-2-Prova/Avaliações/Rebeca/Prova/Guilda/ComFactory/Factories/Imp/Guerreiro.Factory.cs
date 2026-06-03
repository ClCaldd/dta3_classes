public class GuerreiroFactory : IFactory
{
    public IAventureiro Create()
    {
        return new Guerreiro();
    }
}