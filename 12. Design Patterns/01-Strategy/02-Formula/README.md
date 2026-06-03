# Atividade Formula

Brinque utilizando o pacote fórmula, desenvolvido para praticar a troca de padrões e estratégias.
Para iniciar o projeto:
```powershell
dotnet new install Formula.Template
dotnet new formula [Nome do seu projeto]
```



# Ideia 1
Faça os seguintes comportamentos:
- AndarAleatoriamente: Anda aleatoriamente pelo mapa, quando clicado altera o comportamento do objeto para "SeguirOMouse"
- SeguirOMouse: Segue o mouse, quando clicado altera o comportamento do objeto para "AndarAleatoriamente"

Crie um objeto que inicia com "SeguirOMouse"



# Ideia 2
Faça os seguintes comportamentos:
- AndarNaVertical: Se move aleatoriamente na vertical
- AndarNaHorizontal: Se move aleatoriamente na horizontal
- AndarDiagonal: Se move aleatoriamente na diagonal

Crie um objeto que quando pressionado:
Keys.W -> AndarNaVertical
Keys.D -> AndarNaHorizontal
Keys.E -> AndarNaDiagonal