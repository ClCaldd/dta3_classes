public class Guilda
{
    List<IAventureiro> aventureiros = [];


    public void Attack(Boss boss)
    {  
        foreach(var av in aventureiros)
        {
            Console.WriteLine($"Aventureiro {av.Name} Atacou");
            boss.HP -= av.Damage;

            if(av.Name == "Mago")
                av.HP -= boss.DamageFurioso;
            else
                av.HP -= boss.Damage;
            
            Console.WriteLine($"Boss HP: {boss.HP}\n{av.Name} HP: {av.HP}");

            boss.em.Ataquei();
        } 
    }
    public void Verificar()
    {
        foreach(var av in aventureiros)
        {
            if(av.HP <= 0)
            {
                
                aventureiros.Remove(av);
            }
        }
    }
    public void Add(string tipo)
    {
        if(tipo == "guerreiro")
            aventureiros.Add(new Guerreiro());
        else if(tipo == "tanque")
            aventureiros.Add( new Tanque());
        else if(tipo == "mago")
            aventureiros.Add(new Mago());
    }

}