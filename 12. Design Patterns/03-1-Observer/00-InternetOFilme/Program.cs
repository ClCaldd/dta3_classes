Youtuber alanzokinha = new();
for(int i=0; i<10; i++)
{
    var insc = new Inscrito();
    alanzokinha.em.Inscrever(insc);
}
alanzokinha.em.Inscrever(new Hater());

alanzokinha.PublicarVideo();
