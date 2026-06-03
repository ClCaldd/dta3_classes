namespace Seta.Application;

public interface IPizzaService
{
    void CortarPizza();
    void ServirPizza();
    void AdicionarPizza(PizzaDTO pizza);
    int GetQuantidade();
}