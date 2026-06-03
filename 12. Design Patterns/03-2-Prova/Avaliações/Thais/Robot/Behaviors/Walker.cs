using Robot.Behaviors;
using Robot.Models;

public class Walker : IBehavior
{
    public string Execute(Robo robot)
    {
        var chance = Random.Shared.Next(0, 100);

        if (chance < 6)
            robot.Behavior = new Hacked();
        
        if (chance >= 6 && chance < 21)
            robot.Behavior = new Fighter();
            
        return "andando...";
    }
}