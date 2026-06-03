using robot;

var robo = new Robot(new Caminhando());
for (int i = 0; i < 21; i++)
{
    Console.Write($" [{i}]  [robô]  ");
    robo.Agir();
    Thread.Sleep(100);
}