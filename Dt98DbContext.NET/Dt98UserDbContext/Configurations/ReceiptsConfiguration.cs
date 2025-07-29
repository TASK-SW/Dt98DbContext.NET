using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

public class ReceiptsConfiguration : IEntityTypeConfiguration<Receipts>
{
    #region Public Methods

    public void Configure(EntityTypeBuilder<Receipts> builder)
    {
        builder.ToTable("RECEIPTS");

        builder.HasKey(r => r.OidReceipt);

        builder.Property(r => r.OidReceipt).HasColumnName("OID");
        builder.Property(r => r.OidCardType).HasColumnName("OID_CARDTYPE");
        builder.Property(r => r.OidTerminal).HasColumnName("OID_TERMINAL");
        builder.Property(r => r.TerminalType).HasColumnName("TERMINALTYPE");
        builder.Property(r => r.Pan).HasColumnName("PAN");
        builder.Property(r => r.PrintCount).HasColumnName("PRINTCOUNT");
        builder.Property(r => r.DateStore).HasColumnName("DATESTORE");
        builder.Property(r => r.DatePrint).HasColumnName("DATEPRINT");
        builder.Property(r => r.ReceiptText).HasColumnName("RECEIPTTEXT");
        builder.Property(r => r.ExtraData).HasColumnName("EXTRADATA");
        builder.Property(r => r.PrinterWidth).HasColumnName("PRINTER_WIDTH");
        builder.Property(r => r.WmFormat).HasColumnName("WM_FORMAT");
        builder.Property(r => r.Pan2).HasColumnName("PAN2");
        builder.Property(r => r.Pan3).HasColumnName("PAN3");
        builder.Property(r => r.Pan4).HasColumnName("PAN4");
        builder.Property(r => r.Pan5).HasColumnName("PAN5");

        // JournalHeader
        builder.HasOne(r => r.Header)
            .WithOne(h => h.Receipt)
            .HasForeignKey<Receipts>(r => r.OidReceipt) // FK в RECEIPTS
            .HasPrincipalKey<JournalHeader>(h => h.Oid) // PK в JOURNALHEADER
            .OnDelete(DeleteBehavior.Restrict);
    }

    #endregion Public Methods
}