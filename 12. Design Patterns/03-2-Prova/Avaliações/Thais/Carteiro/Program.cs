Banca banquinha = new();

for(int i = 0; i < 2; i++)                           
    banquinha.em.Inscrever("emprego", new Inscrito());

for(int i = 0; i < 4; i++)                           
    banquinha.em.Inscrever("assassinato", new Inscrito());  

banquinha.PublicarJornal("cozinha");