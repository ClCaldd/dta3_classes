namespace Seta.Application.PizzaUseCases;

public class AddPizzaUseCase
(
    IPizzaService service
)
{
    public void Do(PizzaDTO pizza)
    {
        if(pizza.Nome.Count() < 3)
        {
            Console.WriteLine("O nome nao pode ter menos que 3 caracteres");
            return;
        }

        service.AdicionarPizza(pizza);
    }
}