using Robot.Behaviors;
using Robot.Models;

public class Fighter : IBehavior
{
    public string Execute(Robo robot)
    {
        var chance = Random.Shared.Next(0, 100);

        if (chance < 6)
            robot.Behavior = new Hacked();
            
        return "COMBATE...";
    }
}