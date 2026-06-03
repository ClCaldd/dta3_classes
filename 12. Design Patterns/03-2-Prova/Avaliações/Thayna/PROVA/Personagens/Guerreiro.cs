using personagem;

public class Guerreiro : IPersonagens
{
    string IPersonagens.Nome { get; set; } = "Guerreiro";
    int IPersonagens.Hp { get; set; } = 60;
    int IPersonagens.Dano { get; set; } = 30;
}