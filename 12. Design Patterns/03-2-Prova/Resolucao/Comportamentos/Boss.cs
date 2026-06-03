
public class Boss : IComportamento
{
    public void Execute(Personagem personagem, Personagem alvo)
    {
        if(alvo.Name == "mago")
        {
            personagem.Dano = 60;
            personagem.Name = "Boss Furioso";
            personagem.SetComportamento(new BossFurioso());
        }

        var dano = Random.Shared.Next(0, personagem.Dano+1);
        alvo.Hp -= dano;
    }
}