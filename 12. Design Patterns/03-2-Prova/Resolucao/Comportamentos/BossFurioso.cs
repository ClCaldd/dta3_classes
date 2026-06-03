public class BossFurioso : IComportamento
{
    public void Execute(Personagem personagem, Personagem alvo)
    {
        var r = Random.Shared.Next(1,3);
        int dano;
        if(r == 1)
            dano = personagem.Dano;
        else
            dano = 0;

            
        alvo.Hp -= dano;
    }
}