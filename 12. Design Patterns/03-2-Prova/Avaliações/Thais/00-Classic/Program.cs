var factory = new Factory();
factory.Define("mac", () => new MacButton());
factory.Define("windows", () => new WindowsButton());
factory.Define("linux", () => new LinuxButton());

// var factory = new WindowsFactory();
var app = new Aplication("windows", factory);
app.Logic();