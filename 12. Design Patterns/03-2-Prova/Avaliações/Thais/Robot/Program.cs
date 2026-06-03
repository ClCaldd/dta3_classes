using Robot.Models;

var robot = new Robo("robozinho", new Walker());
for (int i = 0; i <= 20; i++)
{
    Console.WriteLine(i + " - " + robot.Name + " - Act: " + robot.Act());
}