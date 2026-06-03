using Microsoft.EntityFrameworkCore;

public static class QuartoClassMap
{
    public static void ConfigureQuartoClassMap(this ModelBuilder modelBuilder)
    => modelBuilder.Entity<Quarto>(builder =>
    {
        builder.HasKey(quarto => quarto.Id);
        builder.Property(quarto => quarto.Id)
            .HasColumnName("id");
        builder.ToTable("tb_quarto");
    //================PROPERTIES================
        builder.Property(quarto => quarto.Nome)
            .HasColumnName("nome")
            .IsRequired();

    //================MY-RELATIONS================
        builder.Property(quarto => quarto.CasaId)
            .HasColumnName("casa_id")
            .IsRequired();
        builder.HasOne(quarto => quarto.Casa)
            .WithMany(casa => casa.Quartos)
            .HasForeignKey(quarto => quarto.CasaId);

    //================RELATIONS================
        builder.HasMany(quarto => quarto.Lampadas)
            .WithOne(lampada => lampada.Quarto)
            .HasForeignKey(lampada => lampada.QuartoId);
    });
}