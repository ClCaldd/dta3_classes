using Microsoft.EntityFrameworkCore;

public static class LampadaClassMap
{
    public static void ConfigureLampadaClassMap(this ModelBuilder modelBuilder)
    => modelBuilder.Entity<Lampada>(builder =>
    {
        builder.HasKey(lampada => lampada.Id);
        builder.Property(lampada => lampada.Id)
            .HasColumnName("id");
        builder.ToTable("tb_lampada");
    //================PROPERTIES================
        builder.Property(lampada => lampada.Nome)
            .HasColumnName("nome")
            .IsRequired();
        builder.Property(lampada => lampada.Estado)
            .HasColumnName("estado")
            .IsRequired();
        builder.Property(lampada => lampada.Tipo)
            .HasColumnName("tipo")
            .IsRequired();
        builder.Property(lampada => lampada.Cor)
            .HasColumnName("cor")
            .IsRequired();

    //================MY-RELATIONS================ 
        builder.Property(lampada => lampada.QuartoId)
            .HasColumnName("quarto_id")
            .IsRequired();
        builder.HasOne(lampada => lampada.Quarto)
            .WithMany(quarto => quarto.Lampadas)
            .HasForeignKey(lampada => lampada.QuartoId);

    //================RELATIONS================
        builder.HasMany(lampada => lampada.Grupos)
        .WithMany(grupo => grupo.Lampadas)
        .UsingEntity(
            "tb_lampada_grupo",
            r => r.HasOne(typeof(Grupo)).WithMany().HasForeignKey("grupo_id").HasPrincipalKey(nameof(Grupo.Id)),
            l => l.HasOne(typeof(Lampada)).WithMany().HasForeignKey("lampada_id").HasPrincipalKey(nameof(Lampada.Id)),
            j => j.HasKey("grupo_id","lampada_id")
        );
    });
}