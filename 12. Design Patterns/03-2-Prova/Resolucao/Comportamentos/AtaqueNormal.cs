public class AtaqueNormal : IComportamento
{
    public void Execute(Personagem personagem, Personagem alvo)
    {
        var dano = personagem.Dano;
        alvo.Hp -= dano;
    }
}