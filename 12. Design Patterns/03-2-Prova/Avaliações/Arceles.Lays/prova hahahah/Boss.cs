// Quando o Boss encontrar com um 'mago' ele vai alterar seu modo para furioso, mantendo o Hp atual, e alterando seu dano para 60
// Na program:
// Faça um Loop para manter ambos batalhando até que um seja morto (Logs manuais sáo permitidos);

// (Garanta que eu seja simples e fácil adicionar novos aventureiros que possuem comportamentos novos)

public class Boss : IPersonagem
{
   
    public Ataques Ataque(TipoPersona type, int Dano)
    {
    }
}
public class BossFurioso : IPersonagem
{
    private  int Hp;
    private int dano;

    public Ataques Ataque(TipoPersona type, int Dano)
    {
        
        Dano 
    }
    
}