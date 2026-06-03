using Robot.Behaviors;

namespace Robot.Models;

public class Robo(string name, IBehavior behavior)
{
    public string Name { get; set; } = name;
    public IBehavior Behavior { get; set; } = behavior;

    public string Act()
    {
        return Behavior.Execute(this);
    }
}