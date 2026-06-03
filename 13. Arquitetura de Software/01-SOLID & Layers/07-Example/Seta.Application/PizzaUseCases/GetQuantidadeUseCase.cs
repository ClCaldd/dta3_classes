namespace Seta.Application.PizzaUseCases;

public class GetQuantidadeUseCase(
    IPizzaService service
)
{
    public int Do()
    {
        return service.GetQuantidade();
    }
}