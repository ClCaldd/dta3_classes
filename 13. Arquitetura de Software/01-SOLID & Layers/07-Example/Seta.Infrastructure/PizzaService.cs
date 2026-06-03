using Seta.Application;
using Seta.Domain;

namespace Seta.Infrastructure;

public class PizzaService : IPizzaService
{
    List<Pizza> Pizzas = [];

    public void AdicionarPizza(PizzaDTO pizza)
    {
        var newPizza = new Pizza
        {
            Nome=pizza.Nome,
            Sabor=pizza.Sabor,
            Fatias=pizza.Fatias
        };
        Pizzas.Add(newPizza);        
    }

    public void CortarPizza()
    {
        Console.WriteLine("Pizza cortada!");
    }

    public int GetQuantidade()
    {
        return Pizzas.Count;
    }

    public void ServirPizza()
    {
        Console.WriteLine("Pizza servida!");
    }
}