public class Personagem : IPersonagem
{
    public string? Name { get ; set ; }
    public TipoPersona type { get ; set ; }
    public int Hp { get ; set ; }
    public int Dano { get ; set ; }

    public Ataques Ataque(TipoPersona type, int Dano)
    {
        throw new NotImplementedException();
    }
}