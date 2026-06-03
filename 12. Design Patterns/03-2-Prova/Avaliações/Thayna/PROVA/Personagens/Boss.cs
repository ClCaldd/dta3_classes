using personagem;

public class BossPersonagem : IPersonagens
{
    string IPersonagens.Nome { get; set; } = "Boss";
    int IPersonagens.Hp { get; set; } = 800;
    int IPersonagens.Dano { get; set; } = Random.Shared.Next(0,30);
}