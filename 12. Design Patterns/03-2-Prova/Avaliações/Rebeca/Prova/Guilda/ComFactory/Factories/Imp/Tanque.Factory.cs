public class TanqueFactory : IFactory
{
    public IAventureiro Create()
    {
        return new Tanque();
    }
}