using System.Diagnostics;
using System.Runtime.Versioning;

using personagem;

public class Guilda
{
    List<IPersonagens> guilda_list = [];
    Boss boss_ataque = new Boss();

    public void Attack(IPersonagens boss)
    {
        foreach (var i in guilda)
        {   
            int num = 1;

            boss_ataque.BossAttack(i, boss);

            boss.Hp -= i.Dano;
            i.Hp -= boss.Dano;

            Console.WriteLine($"Rodada {num}");

            Console.WriteLine($"{i.Nome} atacou {boss.Nome}! \n" +
            $"{boss.Nome} está com {boss.Hp} de vida!");

            Console.WriteLine($"{boss.Nome} atacou {i.Nome}! \n" +
            $"{i.Nome} está com {i.Hp} de vida!");

            num += 1;
        }

    }
}