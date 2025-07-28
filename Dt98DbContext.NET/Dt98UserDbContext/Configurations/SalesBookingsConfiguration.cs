
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class SalesBookingsConfiguration : IEntityTypeConfiguration<SalesBookings>
    {
        public void Configure(EntityTypeBuilder<SalesBookings> builder)
        {
            builder.ToTable("SALESBOOKINGS");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.OidSales).HasColumnName("OID_SALES");
            builder.Property(e => e.ArticleId).HasColumnName("ARTICLEID");
            builder.Property(e => e.Article).HasColumnName("ARTICLE");
            builder.Property(e => e.ShortName).HasColumnName("SHORTNAME");
            builder.Property(e => e.ReceiptText).HasColumnName("RECEIPTTEXT");
            builder.Property(e => e.Quantity).HasColumnName("QUANTITY");
            builder.Property(e => e.UnitPrice).HasColumnName("UNITPRICE");
            builder.Property(e => e.Tax).HasColumnName("TAX");
            builder.Property(e => e.FpId).HasColumnName("FPID");
            builder.Property(e => e.NozzleId).HasColumnName("NOZZLEID");
            builder.Property(e => e.FpAmount).HasColumnName("FPAMOUNT");
            builder.Property(e => e.ArtSubGrp).HasColumnName("ARTSUBGRP");
            builder.Property(e => e.ArtGrp).HasColumnName("ARTGRP");
            builder.Property(e => e.Unit).HasColumnName("UNIT");
            builder.Property(e => e.OidStornoOrigin).HasColumnName("OID_STORNO_ORIGIN");
            builder.Property(e => e.DscType).HasColumnName("DSC_TYPE");
            builder.Property(e => e.DscRate).HasColumnName("DSC_RATE");
            builder.Property(e => e.DscAmt).HasColumnName("DSC_AMT");
            builder.Property(e => e.EanCode).HasColumnName("EANCODE");
            builder.Property(e => e.VideosEqNo).HasColumnName("VIDEO_SEQ_NO");
            builder.Property(e => e.FpCrc).HasColumnName("FP_CRC");
            builder.Property(e => e.DtAuthorize).HasColumnName("DT_AUTHORIZE");
            builder.Property(e => e.DtStart).HasColumnName("DT_START");
            builder.Property(e => e.DtEnd).HasColumnName("DT_END");
            builder.Property(e => e.TiConfig).HasColumnName("TI_CONFIG");
            builder.Property(e => e.FrgnIdCny).HasColumnName("FRGN_ID_CNY");
            builder.Property(e => e.FrgnUnitPrc).HasColumnName("FRGN_UNIT_PRC");
        }
    }
}
