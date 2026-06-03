// contém uma STRATEGY

public class Personagem(string name, int hp, int dano, IComportamento comportamento)
{

    public GerenciadorDeEventos gerenciadorDeEventos {get;set;} = new();
    public string Name {get;set;} = name;
    public int Hp {get;set;} = hp;
    public int Dano {get;set;} = dano;
    private IComportamento Comportamento = comportamento;

    public void Attack(Personagem alvo)
    {
        Comportamento.Execute(this, alvo);
        gerenciadorDeEventos.Notificar();
    }
    public void SetComportamento(IComportamento comportamento)
    => Comportamento = comportamento;
}