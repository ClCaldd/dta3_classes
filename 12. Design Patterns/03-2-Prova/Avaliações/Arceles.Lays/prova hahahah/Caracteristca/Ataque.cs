// Voce irá simular uma batalha entre uma Guilda e um Boss. Para isso precisaremos ter:
// - O Tanque (100 de hp, 15 de dano)
// - O Guerreiro (60 de hp, 30 de dano)
// - O Mago (40 de hp, 60 de dano)
// - O Boss (800 de hp, dano aleatório entre 0-30)
// - O Boss Furioso (800 de hp, dano é 0 ou 60)

public class Ataques(TipoPersona type, int dano)
{ 
    public int Dano { get; set; } = dano;
    public TipoPersona Tipo { get; set;} = type;

}