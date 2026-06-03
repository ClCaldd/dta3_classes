public class LinuxButtonFactory : ButtonFactory
{
    public Button Create()
    {
        Console.WriteLine("LinuxButton");
        return new LinuxButton();
    }
}