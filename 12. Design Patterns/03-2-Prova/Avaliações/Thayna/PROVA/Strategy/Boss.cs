using personagem;

public class Boss : IEstrategia
{
    public void BossAttack(IPersonagens aventureiro, IPersonagens boss)
    {
        if(aventureiro.Nome == "Mago")
        {
            boss.Nome = "Boss Furioso";
            boss.Dano = 60;
            boss.Hp = 800;

            Console.WriteLine("BOSS **FURIOSO** ATIVADO!!!");
        }
        
    }
}