using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

public class Boss 
{
    public int Hp { get; set; } = 600;
    public int Dano { get; set; }
    public IStrategy Strategy {get; set;}

    public EventManager em {get; set;} = new();

    public Boss (IStrategy strategy, Guild guild)
    {
        foreach (IAdventurous adventurous in guild.adventurers)
        {
            if (adventurous.Name == "Mago")
                Strategy = new FuriousBoss();
        }
    }

    // talvez isso daqui não faça mto sentido, mas o ataque é integral pra todo mundo (boss ficou op demais, sem condições)
    public int Attack()
    {
        // for (int i = 0; i < guild.adventurers.Count; i ++)
        // {
        //     guild.adventurers[i].Hp -= Strategy.Attack();
        //     if (guild.adventurers[i].Hp <= 0)
        //     {
        //         Console.WriteLine($"{guild.adventurers[i].Name} died!");
        //         guild.adventurers.Remove(guild.adventurers[i]);
        //     }
        // }
        em.Send(Strategy.Attack);
        return Strategy.Attack();


    }

}