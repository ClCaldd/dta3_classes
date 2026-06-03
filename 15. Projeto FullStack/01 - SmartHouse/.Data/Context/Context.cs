using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class Context(DbContextOptions<Context> ctx) : DbContext(ctx)
{
    public DbSet<Casa> Casas {get;set;}
    public DbSet<Grupo> Grupos {get;set;}
    public DbSet<Lampada> Lampadas {get;set;}
    public DbSet<Participante> Participantes {get;set;}
    public DbSet<Quarto> Quartos {get;set;}
    public DbSet<Usuario> Usuarios {get;set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ConfigureCasaClassMap();
        modelBuilder.ConfigureGrupoClassMap();
        modelBuilder.ConfigureLampadaClassMap();
        modelBuilder.ConfigureParticipanteClassMap();
        modelBuilder.ConfigureQuartoClassMap();
        modelBuilder.ConfigureUsuarioClassMap();
        // modelBuilder.Configur(); 

        base.OnModelCreating(modelBuilder);
    }
}
