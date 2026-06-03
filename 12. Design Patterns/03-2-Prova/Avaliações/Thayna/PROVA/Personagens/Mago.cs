using personagem;

public class Mago : IPersonagens
{
    string IPersonagens.Nome { get; set; } = "Mago";
    int IPersonagens.Hp { get; set; } = 40;
    int IPersonagens.Dano { get; set; } = 60;
}