using Microsoft.EntityFrameworkCore;

public static class UsuarioClassMap
{
    public static void ConfigureUsuarioClassMap(this ModelBuilder modelBuilder)
    => modelBuilder.Entity<Usuario>(builder =>
    {
        builder.HasKey(usuario => usuario.Id);
        builder.Property(usuario => usuario.Id)
            .HasColumnName("id");

        builder.ToTable("tb_usuario");
    //================PROPERTIES================
        builder.Property(usuario => usuario.Nome)
            .HasColumnName("nome")
            .IsRequired();

    //================RELATIONS================
        builder.HasMany(usuario => usuario.Participantes)
            .WithOne(participante => participante.Usuario)
            .HasForeignKey(partcipante => partcipante.UsuarioId);
    });
}