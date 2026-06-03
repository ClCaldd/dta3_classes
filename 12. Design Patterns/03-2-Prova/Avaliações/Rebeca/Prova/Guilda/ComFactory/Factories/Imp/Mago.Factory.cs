public class MagoFactory : IFactory
{
    public IAventureiro Create()
    {
        return new Mago();
    }
}