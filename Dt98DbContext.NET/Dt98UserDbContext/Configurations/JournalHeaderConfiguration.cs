using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class JournalHeaderConfiguration : IEntityTypeConfiguration<JournalHeader>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<JournalHeader> builder)
        {
            builder.ToTable("JOURNALHEADER");

            builder.HasKey(jh => jh.Oid);
            builder.Property(jh => jh.Oid).HasColumnName("OID");

            builder.Property(jh => jh.RecType).HasColumnName("RECTYPE");
            builder.Property(jh => jh.JournalId).HasColumnName("JOURNALID");
            builder.Property(jh => jh.DateTime).HasColumnName("DATETIME");
            builder.Property(jh => jh.TerminalId).HasColumnName("TERMINALID");
            builder.Property(jh => jh.Account).HasColumnName("ACCOUNT");
            builder.Property(jh => jh.CardNumber).HasColumnName("CARDNUMBER");
            builder.Property(jh => jh.CardInfo).HasColumnName("CARDINFO");
            builder.Property(jh => jh.NetTotal).HasColumnName("NETTOTAL");
            builder.Property(jh => jh.TaxTotal).HasColumnName("TAXTOTAL");
            builder.Property(jh => jh.Track1).HasColumnName("TRACK_1");
            builder.Property(jh => jh.Track2).HasColumnName("TRACK_2");
            builder.Property(jh => jh.Track3).HasColumnName("TRACK_3");
            builder.Property(jh => jh.Chip).HasColumnName("CHIP");
            builder.Property(jh => jh.AmtAuthorized).HasColumnName("AMT_AUTHORIZED");
            builder.Property(jh => jh.AmtPaid).HasColumnName("AMT_PAID");
            builder.Property(jh => jh.LayoutJournal).HasColumnName("LAYOUTJOURNAL");
            builder.Property(jh => jh.LayoutReceipt).HasColumnName("LAYOUTRECEIPT");
            builder.Property(jh => jh.LayoutCardInfo).HasColumnName("LAYOUTCARDINFO");
            builder.Property(jh => jh.TerminationCode).HasColumnName("TERMINATIONCODE");
            builder.Property(jh => jh.ErrorCode).HasColumnName("ERRORCODE");
            builder.Property(jh => jh.AmtRest).HasColumnName("AMT_REST");
            builder.Property(jh => jh.TrxSeqNo).HasColumnName("TRXSEQNO");
            builder.Property(jh => jh.TrxCount).HasColumnName("TRXCOUNT");
            builder.Property(jh => jh.ArtDetailType).HasColumnName("ARTDETAILTYPE");
            builder.Property(jh => jh.PaymentType).HasColumnName("PAYMENTTYPE");
            builder.Property(jh => jh.Language).HasColumnName("LANGUAGE");
            builder.Property(jh => jh.OidStornoOrigin).HasColumnName("OID_STORNO_ORIGIN");
            builder.Property(jh => jh.StornoType).HasColumnName("STORNOTYPE");
            builder.Property(jh => jh.IdStrRt).HasColumnName("ID_STR_RT");
            builder.Property(jh => jh.IdWs).HasColumnName("ID_WS");
            builder.Property(jh => jh.IdopR).HasColumnName("ID_OPR");
            builder.Property(jh => jh.TsTmSRt).HasColumnName("TS_TM_SRT");
            builder.Property(jh => jh.AmtRnd).HasColumnName("AMT_RND");
            builder.Property(jh => jh.AmtRcv).HasColumnName("AMT_RCV");
            builder.Property(jh => jh.AmtRtn).HasColumnName("AMT_RTN");
            builder.Property(jh => jh.RndType).HasColumnName("RND_TYPE");
            builder.Property(jh => jh.CardName).HasColumnName("CARD_NAME");
            builder.Property(jh => jh.AccountNo).HasColumnName("ACCOUNT_NO");
            builder.Property(jh => jh.ForeignCny).HasColumnName("FOREIGN_CNY");
            builder.Property(jh => jh.DscType).HasColumnName("DSC_TYPE");
            builder.Property(jh => jh.DscRate).HasColumnName("DSC_RATE");
            builder.Property(jh => jh.DscAmt).HasColumnName("DSC_AMT");
            builder.Property(jh => jh.DscAmtTot).HasColumnName("DSC_AMTTOT");
            builder.Property(jh => jh.AuthInfo).HasColumnName("AUTH_INFO");
            builder.Property(jh => jh.HostDeliveryState).HasColumnName("HOSTDELIVERYSTATE");
            builder.Property(jh => jh.DscTypeId).HasColumnName("DSC_TYPE_ID");
            builder.Property(jh => jh.DscTypeName).HasColumnName("DSC_TYPE_NAME");
            builder.Property(jh => jh.DscRefNo).HasColumnName("DSC_REF_NO");
            builder.Property(jh => jh.MatchCode).HasColumnName("MATCH_CODE");

            builder.HasMany(jh => jh.JournalCurrency)
                   .WithOne(jc => jc.Header)
                   .HasForeignKey(jc => jc.OidJournal)
                   .HasPrincipalKey(jh => jh.Oid);

            builder.HasMany(jh => jh.JournalBookings)
                   .WithOne(jb => jb.Header)
                   .HasForeignKey(jb => jb.OidJournal)
                   .HasPrincipalKey(jh => jh.Oid);
        }

        #endregion Public Methods
    }
}