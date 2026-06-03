namespace Seta.Application.PizzaUseCases;

public class CortarPizzaUseCase
(
    IPizzaService service
)
{
    public void Do()
    {
        service.CortarPizza();
    }
}