using Seta.Application;
using Seta.Application.PizzaUseCases;
using Seta.Infrastructure;

var service = new PizzaService();
var addUseCase = new AddPizzaUseCase(service);
var cortarPizzaUseCase = new CortarPizzaUseCase(service);
var getQuantidade = new GetQuantidadeUseCase(service);

while(true)
{
    Console.WriteLine(@"
        1 - Adicionar Pizza
        2 - Cortar Pizza
        3 - Ver Quantidade
    ");
    var op = Console.ReadLine();
    if(op is null)
        continue;

    switch(op)
    {
        case "1":
            Console.Write("Nome:\n>> ");
            var nome = Console.ReadLine();
            Console.Write("Sabor:\n>> ");
            var sabor = Console.ReadLine();
            Console.Write("Fatias:\n>> 1");
            var fatias = 1;

            PizzaDTO pizza = new(
                nome!,
                sabor!,
                fatias
            );
            addUseCase.Do(pizza);
            break;

        case "2":
            cortarPizzaUseCase.Do();
            break;

        case "3":
            var qt = getQuantidade.Do();
            Console.WriteLine(qt);
            break;

        default:
            break;
    }
}
