using Microsoft.EntityFrameworkCore;

public static class ParticipanteClassMap
{
    public static void ConfigureParticipanteClassMap(this ModelBuilder modelBuilder)
    => modelBuilder.Entity<Participante>(builder =>
    {
        builder.HasKey(participante => participante.Id);
        builder.Property(participante => participante.Id)
            .HasColumnName("id");
        builder.ToTable("tb_participante");
    
    //================PROPERTIES================
        builder.Property(participante => participante.Admin)
            .HasColumnName("admin")
            .IsRequired();

    //================MY-RELATIONS================
        builder.Property(participante => participante.UsuarioId)
            .HasColumnName("usuario_id");
        builder.HasOne(participante => participante.Usuario)
            .WithMany(usuario => usuario.Participantes)
            .HasForeignKey(participante => participante.UsuarioId);

        builder.Property(participante => participante.CasaId)
            .HasColumnName("casa_id");
        builder.HasOne(participante => participante.Casa)
            .WithMany(casa => casa.Participantes)
            .HasForeignKey(participante => participante.CasaId);
    });
}