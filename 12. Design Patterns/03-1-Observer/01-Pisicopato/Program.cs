Banca banca = new();
// for(int i=0; i<17; i++)
//     banca.em.Subscribe("assassinato", new User());
// for(int i=0; i<3; i++)
//     banca.em.Subscribe("emprego", new User());
for(int i=0; i<17; i++)
{
    var user = new User();
    banca.OnPost += (jornal) => { user.Update(jornal); };
}
for(int i=0; i<3; i++)
{
    var user = new User();
    banca.OnPost() += user.Update;
}

banca.Post("assassinato");