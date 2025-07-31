using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

public class JournalKassenSichConfiguration : IEntityTypeConfiguration<JournalKassenSich>
{
    #region Public Methods

    public void Configure(EntityTypeBuilder<JournalKassenSich> builder)
    {
        builder.ToTable("JOURNALKASSENSICH");

        builder.HasKey(r => r.OidJournal);

        builder.Property(r => r.OidJournal).HasColumnName("OID_JOURNAL");
        builder.Property(r => r.ProcessType).HasColumnName("ProcessType");
        builder.Property(r => r.ProcessData).HasColumnName("ProcessData");
        builder.Property(r => r.TransactionNumber).HasColumnName("TransactionNumber");
        builder.Property(r => r.SignatureCounter).HasColumnName("SignatureCounter");
        builder.Property(r => r.StartTime).HasColumnName("StartTime");
        builder.Property(r => r.LogTime).HasColumnName("LogTime");
        builder.Property(r => r.SignAlgorithm).HasColumnName("SignAlgorithm");
        builder.Property(r => r.LogTimeFormat).HasColumnName("LogTimeFormat");
        builder.Property(r => r.Signature).HasColumnName("Signature");
        builder.Property(r => r.PublicKey).HasColumnName("PublicKey");
        builder.Property(r => r.TseSerialNumber).HasColumnName("TseSerialNumber");
        builder.Property(r => r.SignatureError).HasColumnName("SignatureError");

        // JournalHeader
        builder.HasOne(r => r.Header)
            .WithOne(h => h.JournalKassenSich)
            .HasForeignKey<JournalKassenSich>(r => r.OidJournal) // FK в JOURNALKASSENSICH
            .HasPrincipalKey<JournalHeader>(h => h.Oid) // PK в JOURNALHEADER
            .OnDelete(DeleteBehavior.Restrict);
    }

    #endregion Public Methods
}