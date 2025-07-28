using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

public class ArticlesConfiguration : IEntityTypeConfiguration<Articles>
{
    #region Public Methods

    public void Configure(EntityTypeBuilder<Articles> builder)
    {
        builder.ToTable("ARTICLES");

        builder.HasKey(a => a.Oid);

        builder.Property(a => a.Oid).HasColumnName("OID");
        builder.Property(a => a.OidArtSubGrp).HasColumnName("OID_ARTSUBGRP");
        builder.Property(a => a.OidTax).HasColumnName("OID_TAX");
        builder.Property(a => a.Id).HasColumnName("ID");
        builder.Property(a => a.EanCode).HasColumnName("EANCODE");
        builder.Property(a => a.Name).HasColumnName("NAME");
        builder.Property(a => a.ShortName).HasColumnName("SHORTNAME");
        builder.Property(a => a.ReceiptText).HasColumnName("RECEIPTTEXT");
        builder.Property(a => a.SalesPrice).HasColumnName("SALES_PRICE");
        builder.Property(a => a.SalesUnit).HasColumnName("SALES_UNIT");
        builder.Property(a => a.SalesQuantity).HasColumnName("SALES_QUANTITY");
        builder.Property(a => a.NormUnit).HasColumnName("NORM_UNIT");
        builder.Property(a => a.NormQuantity).HasColumnName("NORM_QUANTITY");
        builder.Property(a => a.NormPrice).HasColumnName("NORM_PRICE");
        builder.Property(a => a.VoucherEnabled).HasColumnName("VOUCHER_ENABLED");
        builder.Property(a => a.VoucherValIdFrom).HasColumnName("VOUCHER_VALID_FROM");
        builder.Property(a => a.VoucherValIdtO).HasColumnName("VOUCHER_VALID_TO");
        builder.Property(a => a.VoucherValIdDays).HasColumnName("VOUCHER_VALID_DAYS");
        builder.Property(a => a.VoucherThreshOld).HasColumnName("VOUCHER_THRESHOLD");
        builder.Property(a => a.VoucherMinAmount).HasColumnName("VOUCHER_MIN_AMOUNT");
        builder.Property(a => a.VoucherDscPerLiter).HasColumnName("VOUCHER_DSC_PER_LITER");
    }

    #endregion Public Methods
}