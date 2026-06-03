// nao deu tempppoooooooooo

Factory factory = new();

factory.Add("guerreiro", () => new Guerreiro());
factory.Add("boss", () => new BossPersonagem());
factory.Add("mago", () => new Mago());
factory.Add("tanque", () => new Tanque());

var guilda = new Guilda();
