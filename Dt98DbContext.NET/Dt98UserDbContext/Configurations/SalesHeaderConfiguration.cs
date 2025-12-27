using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class SalesHeaderConfiguration : IEntityTypeConfiguration<SalesHeader>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<SalesHeader> builder)
        {
            builder.ToTable("SALESHEADER");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.DateTime).HasColumnName("DATETIME");
            builder.Property(e => e.TerminalId).HasColumnName("TERMINALID");
            builder.Property(e => e.Account).HasColumnName("ACCOUNT");
            builder.Property(e => e.CardNumber).HasColumnName("CARDNUMBER");
            builder.Property(e => e.OidStornoOrigin).HasColumnName("OID_STORNO_ORIGIN");
            builder.Property(e => e.StornoType).HasColumnName("STORNOTYPE");
            builder.Property(e => e.IdStrRt).HasColumnName("ID_STR_RT");
            builder.Property(e => e.IdWs).HasColumnName("ID_WS");
            builder.Property(e => e.IdopR).HasColumnName("ID_OPR");
            builder.Property(e => e.TsTmSRt).HasColumnName("TS_TM_SRT");
            builder.Property(e => e.AmtRnd).HasColumnName("AMT_RND");
            builder.Property(e => e.AmtRcv).HasColumnName("AMT_RCV");
            builder.Property(e => e.AmtRtn).HasColumnName("AMT_RTN");
            builder.Property(e => e.FrgnIdCny).HasColumnName("FRGN_ID_CNY");
            builder.Property(e => e.FrgnSyCny).HasColumnName("FRGN_SY_CNY");
            builder.Property(e => e.FrgnExchgRateRcv).HasColumnName("FRGN_EXCHG_RATE_RCV");
            builder.Property(e => e.FrgnExchgRateRtn).HasColumnName("FRGN_EXCHG_RATE_RTN");
            builder.Property(e => e.FrgnExchgFee).HasColumnName("FRGN_EXCHG_FEE");
            builder.Property(e => e.FrgnAmtSale).HasColumnName("FRGN_AMT_SALE");
            builder.Property(e => e.FrgnAmtRcv).HasColumnName("FRGN_AMT_RCV");
            builder.Property(e => e.FrgnAmtRtn).HasColumnName("FRGN_AMT_RTN");
            builder.Property(e => e.DscType).HasColumnName("DSC_TYPE");
            builder.Property(e => e.DscRate).HasColumnName("DSC_RATE");
            builder.Property(e => e.DscAmt).HasColumnName("DSC_AMT");
            builder.Property(e => e.AuthInfo).HasColumnName("AUTH_INFO");
            builder.Property(e => e.CardProcOid).HasColumnName("CARDPROCOID");
            builder.Property(e => e.FundingInfo).HasColumnName("FUNDINGINFO");
            builder.Property(e => e.DscTypeId).HasColumnName("DSC_TYPE_ID");
            builder.Property(e => e.DscTypeName).HasColumnName("DSC_TYPE_NAME");
            builder.Property(e => e.DscRefNo).HasColumnName("DSC_REF_NO");
            builder.Property(e => e.FrgnTyTnd).HasColumnName("FRGN_TY_TND");
            builder.Property(e => e.FrgnLocalAmtRnd).HasColumnName("FRGN_LOCAL_AMT_RND");
            builder.Property(e => e.FrgnDeTnd).HasColumnName("FRGN_DE_TND");
            builder.Property(e => e.SecondCard).HasColumnName("SECOND_CARD");
            builder.Property(e => e.MatchCode).HasColumnName("MATCH_CODE");
        }

        #endregion Public Methods
    }
}