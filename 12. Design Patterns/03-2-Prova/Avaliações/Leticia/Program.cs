Factory factory = new Factory();

factory.addFunc("mago", () => new Mago());
factory.addFunc("tank", ()=> new Tank());
factory.addFunc("warrior", ()=> new Warrior());

Guild guild = new Guild(factory);
guild.Add("mago");
guild.Add("tank");
guild.Add("warrior");

Boss boss = new Boss(new BossStrategy(), guild);
Battle battle = new Battle(guild, boss);

battle.Start();



