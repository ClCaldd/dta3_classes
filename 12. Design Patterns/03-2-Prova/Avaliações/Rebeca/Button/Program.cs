var factory = new Factory();

factory.AddOS("mac", () => new MacButton());
factory.AddOS("linux", () => new LinuxButton());
factory.AddOS("windows", () => new WindowsButton());

var app = new Aplication("windows", factory);

app.Create();
