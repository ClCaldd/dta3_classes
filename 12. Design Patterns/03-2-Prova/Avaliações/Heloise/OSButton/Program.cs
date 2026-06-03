Factory factory = new();

factory.Add("Pinguas", () => new LinuxButton());

factory.Add("Raspibery", () => new MacButton());
// factory.Add("Birulecuteco", () => new WindowsButton());

var app = new Application("Raspibery", factory);
app.Logic();