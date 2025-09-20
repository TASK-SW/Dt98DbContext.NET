using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class FuelSalesConfiguration : IEntityTypeConfiguration<FuelSales>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<FuelSales> builder)
        {
            builder.ToTable("FUELSALES");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.DateTime).HasColumnName("DATETIME");
            builder.Property(e => e.State).HasColumnName("STATE");
            builder.Property(e => e.TerminalId).HasColumnName("TERMINALID");
            builder.Property(e => e.Account).HasColumnName("ACCOUNT");
            builder.Property(e => e.CardNumber).HasColumnName("CARDNUMBER");
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
            builder.Property(e => e.VideosEqNo).HasColumnName("VIDEO_SEQ_NO");
            builder.Property(e => e.FpCrc).HasColumnName("FP_CRC");
            builder.Property(e => e.CardProcOid).HasColumnName("CARDPROCOID");
            builder.Property(e => e.FundingInfo).HasColumnName("FUNDINGINFO");
            builder.Property(e => e.DscTypeId).HasColumnName("DSC_TYPE_ID");
            builder.Property(e => e.DscTypeName).HasColumnName("DSC_TYPE_NAME");
            builder.Property(e => e.DscRefNo).HasColumnName("DSC_REF_NO");
            builder.Property(e => e.DtAuthorize).HasColumnName("DT_AUTHORIZE");
            builder.Property(e => e.DtStart).HasColumnName("DT_START");
            builder.Property(e => e.DtEnd).HasColumnName("DT_END");
            builder.Property(e => e.SecondCard).HasColumnName("SECOND_CARD");
            builder.Property(e => e.TiConfig).HasColumnName("TI_CONFIG");
        }

        #endregion Public Methods
    }
}