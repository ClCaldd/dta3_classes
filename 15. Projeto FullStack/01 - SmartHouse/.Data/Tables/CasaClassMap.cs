using Microsoft.EntityFrameworkCore;

public static class CasaClassMap
{
    public static void ConfigureCasaClassMap(this ModelBuilder modelBuilder)
    => modelBuilder.Entity<Casa>(builder =>
    {
        builder.HasKey(casa => casa.Id);
        builder.Property(casa => casa.Id)
            .HasColumnName("id");
        builder.ToTable("tb_casa");
    //================PROPERTIES================
        builder.Property(casa => casa.Nome)
            .HasColumnName("nome");

    //================RELATIONS================
        builder.HasMany(casa => casa.Participantes)
            .WithOne(participante => participante.Casa)
            .HasForeignKey(participante => participante.CasaId);
        
        builder.HasMany(casa => casa.Quartos)
            .WithOne(quarto => quarto.Casa)
            .HasForeignKey(quarto => quarto.CasaId);
    });
}