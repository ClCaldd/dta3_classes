using personagem;

public class Tanque : IPersonagens
{
    string IPersonagens.Nome { get; set; } = "Tanque";
    int IPersonagens.Hp { get; set; } = 100;
    int IPersonagens.Dano { get; set; } = 15;
}