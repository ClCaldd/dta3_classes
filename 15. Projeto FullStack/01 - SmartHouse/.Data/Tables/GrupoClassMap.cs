using Microsoft.EntityFrameworkCore;

public static class GrupoClassMap
{
    public static void ConfigureGrupoClassMap(this ModelBuilder modelBuilder)
    => modelBuilder.Entity<Grupo>(builder =>
    {
        builder.HasKey(casa => casa.Id);
        builder.Property(casa => casa.Id)
            .HasColumnName("id");
        builder.ToTable("tb_grupo");

    //================PROPERTIES================
        builder.Property(grupo => grupo.Nome)
            .HasColumnName("grupo")
            .IsRequired();
        builder.Property(grupo => grupo.Estado)
            .HasColumnName("estado")
            .IsRequired();

    //================RELATIONS================
        builder.HasMany(grupo => grupo.Lampadas)
            .WithMany(lampada => lampada.Grupos)
            .UsingEntity(
                "tb_lampada_grupo",
                r => r.HasOne(typeof(Lampada)).WithMany().HasForeignKey("lampada_id").HasPrincipalKey(nameof(Lampada.Id)),
                l => l.HasOne(typeof(Grupo)).WithMany().HasForeignKey("grupo_id").HasPrincipalKey(nameof(Grupo.Id)),
                j => j.HasKey("lampada_id","grupo_id")
            );
    });
}