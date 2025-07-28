
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class CardHandlingConfiguration : IEntityTypeConfiguration<CardHandling>
    {
        public void Configure(EntityTypeBuilder<CardHandling> builder)
        {
            builder.ToTable("_sptCARDHANDLING");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.ChkLuhn).HasColumnName("CHK_LUHN");
            builder.Property(e => e.ChkDate).HasColumnName("CHK_DATE");
            builder.Property(e => e.PinCheckType).HasColumnName("PIN_CHECKTYPE");
            builder.Property(e => e.PinScPos).HasColumnName("PIN_SCPOS");
            builder.Property(e => e.PinScVal).HasColumnName("PIN_SCVAL");
            builder.Property(e => e.LimitMin).HasColumnName("LIMIT_MIN");
            builder.Property(e => e.LimitFloor1).HasColumnName("LIMIT_FLOOR1");
            builder.Property(e => e.LimitFloor2).HasColumnName("LIMIT_FLOOR2");
            builder.Property(e => e.ProcessingType).HasColumnName("PROCESSINGTYPE");
            builder.Property(e => e.DefaultAmount).HasColumnName("DEFAULTAMOUNT");
            builder.Property(e => e.LimitDateFrom).HasColumnName("LIMIT_DATEFROM");
            builder.Property(e => e.LimitDateTo).HasColumnName("LIMIT_DATETO");
            builder.Property(e => e.PinSkip).HasColumnName("PIN_SKIP");
            builder.Property(e => e.LenVerifyNo).HasColumnName("LENVERIFYNO");
            builder.Property(e => e.ChkCardLen).HasColumnName("CHK_CARDLEN");
            builder.Property(e => e.LimitTotalAmount).HasColumnName("LIMIT_TOTALAMOUNT");
            builder.Property(e => e.LimitOutdoorAmount).HasColumnName("LIMIT_OUTDOORAMOUNT");
            builder.Property(e => e.CountKeyCards).HasColumnName("COUNTKEYCARDS");
            builder.Property(e => e.KeyPos).HasColumnName("KEYPOS");
            builder.Property(e => e.IssuerLen).HasColumnName("ISSUERLEN");
            builder.Property(e => e.Mode).HasColumnName("MODE");
            builder.Property(e => e.TermCodeTabId).HasColumnName("TERMCODETABID");
            builder.Property(e => e.ProdCodeTabId).HasColumnName("PRODCODETABID");
            builder.Property(e => e.ReceiptCount).HasColumnName("RECEIPTCOUNT");
            builder.Property(e => e.OidKeyCardHandling).HasColumnName("OID_KEYCARDHANDLING");
        }
    }
}
