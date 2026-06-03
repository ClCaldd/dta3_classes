public class GuerreiroFactory : IAventurreiroFactory
{
    public IAventureiro Create()
    {
        return new Aventureiro("guerreiro", new GuerreiroStrategy());
    }
}