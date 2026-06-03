using Microsoft.EntityFrameworkCore;

public class SeedService
(
    Context ctx
)
{
    private string nomeUsuario = "usuario";
    private string nomeCasa = "casa";
    private string nomeQuarto = "sala";
    public async Task SeedData()
    {
        
        var usuario = await ctx.Usuarios.FirstOrDefaultAsync(u => u.Nome == nomeUsuario);
        if (usuario == null)
        {
            usuario = new Usuario { Nome = nomeUsuario };
            ctx.Usuarios.Add(usuario);
            await ctx.SaveChangesAsync();
        }

        var casa = await ctx.Casas.FirstOrDefaultAsync(c => c.Nome == nomeCasa);
        if (casa == null)
        {
            casa = new Casa { Nome = nomeCasa };
            ctx.Casas.Add(casa);
            await ctx.SaveChangesAsync();
        }

        var participanteExiste = await ctx.Participantes.AnyAsync(p => p.CasaId == casa.Id && p.UsuarioId == usuario.Id);
        if (!participanteExiste)
        {
            ctx.Participantes.Add(new Participante
            {
                Casa=casa,
                CasaId = casa.Id,
                Usuario=usuario,
                UsuarioId = usuario.Id,
                Admin = true
            });
        }

        var quartoExiste = await ctx.Quartos.AnyAsync(q => q.Nome == nomeQuarto && q.CasaId == casa.Id);
        if (!quartoExiste)
        {
            ctx.Quartos.Add(new Quarto
            {
                Nome = nomeQuarto,
                Casa=casa,
                CasaId = casa.Id
            });
        }
        
        await ctx.SaveChangesAsync();
    }
}