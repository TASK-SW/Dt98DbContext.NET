using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class JournalBookingsConfiguration : IEntityTypeConfiguration<JournalBookings>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<JournalBookings> builder)
        {
            builder.ToTable("JOURNALBOOKINGS");

            builder.HasKey(jb => jb.OidBooking);
            builder.Property(jb => jb.OidBooking).HasColumnName("OID");
            builder.Property(jb => jb.OidJournal).HasColumnName("OID_JOURNAL");

            builder.HasOne(jb => jb.Header)
                   .WithMany(jh => jh.JournalBookings)
                   .HasForeignKey(jb => jb.OidJournal)
                   .HasPrincipalKey(jh => jh.Oid);

            builder.Property(jb => jb.BookingId).HasColumnName("BOOKINGID");
            builder.Property(jb => jb.ArticleId).HasColumnName("ARTICLEID");
            builder.Property(jb => jb.Article).HasColumnName("ARTICLE");
            builder.Property(jb => jb.ShortName).HasColumnName("SHORTNAME");
            builder.Property(jb => jb.ReceiptText).HasColumnName("RECEIPTTEXT");
            builder.Property(jb => jb.Quantity).HasColumnName("QUANTITY");
            builder.Property(jb => jb.UnitPrice).HasColumnName("UNITPRICE");
            builder.Property(jb => jb.Tax).HasColumnName("TAX");
            builder.Property(jb => jb.FpId).HasColumnName("FPID");
            builder.Property(jb => jb.NozzleId).HasColumnName("NOZZLEID");
            builder.Property(jb => jb.FpAmount).HasColumnName("FPAMOUNT");
            builder.Property(jb => jb.ArtSubGrp).HasColumnName("ARTSUBGRP");
            builder.Property(jb => jb.ArtGrp).HasColumnName("ARTGRP");
            builder.Property(jb => jb.Unit).HasColumnName("UNIT");
            builder.Property(jb => jb.OidStornoOrigin).HasColumnName("OID_STORNO_ORIGIN");
            builder.Property(jb => jb.DscType).HasColumnName("DSC_TYPE");
            builder.Property(jb => jb.DscRate).HasColumnName("DSC_RATE");
            builder.Property(jb => jb.DscAmt).HasColumnName("DSC_AMT");
            builder.Property(jb => jb.EanCode).HasColumnName("EANCODE");
            builder.Property(jb => jb.VideosEqNo).HasColumnName("VIDEO_SEQ_NO");
            builder.Property(jb => jb.FpCrc).HasColumnName("FP_CRC");
            builder.Property(jb => jb.FrgnIdCny).HasColumnName("FRGN_ID_CNY");
            builder.Property(jb => jb.FrgnUnitPrc).HasColumnName("FRGN_UNIT_PRC");

            // 👇 One-way lazy-loaded relation to Units
            builder.HasOne(jb => jb.Units)
                .WithMany() // no navigation back
                .HasForeignKey(jb => jb.Unit)
                .HasPrincipalKey(u => u.Id)
                .OnDelete(DeleteBehavior.Restrict);

            // 👇 One-way lazy-loaded relation to EanCodes
            builder.HasOne(jb => jb.EanCodes)
                .WithMany() // no navigation back
                .HasForeignKey(jb => jb.ArticleId)
                .HasPrincipalKey(u => u.OidArticle)
                .OnDelete(DeleteBehavior.Restrict);
        }

        #endregion Public Methods
    }
}