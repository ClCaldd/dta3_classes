Banca banca = new();
List<string> tipos = ["assainato", "emprego", "fofocas"];
for(int i=0; i< 10; i++)
{
    var insc = new Inscrito(tipos[Random.Shared.Next(0,3)]);
    banca.em.Inscrever(insc);
}

banca.Publicar("assasinato");