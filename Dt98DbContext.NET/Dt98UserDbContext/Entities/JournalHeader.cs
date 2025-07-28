using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class JournalHeader
    {
        #region Private Fields

        private ICollection<JournalCurrency> _journalCurrency;

        private ICollection<JournalBookings> _journalBookings;

        private Receipts _receipt;

        #endregion Private Fields

        #region Private Properties

        private ILazyLoader LazyLoader { get; set; }

        #endregion Private Properties

        #region Public Constructors

        public JournalHeader()
        { }

        public JournalHeader(ILazyLoader lazyLoader)
        {
            LazyLoader = lazyLoader;
        }

        #endregion Public Constructors

        #region Public Properties

        public string Oid { get; set; }

        public ICollection<JournalCurrency> JournalCurrency
        {
            get => LazyLoader.Load(this, ref _journalCurrency);
            set => _journalCurrency = value;
        }

        public ICollection<JournalBookings> JournalBookings
        {
            get => LazyLoader.Load(this, ref _journalBookings);
            set => _journalBookings = value;
        }

        public Receipts Receipt
        {
            get => LazyLoader.Load(this, ref _receipt);
            set => _receipt = value;
        }

        public int RecType { get; set; }
        public int JournalId { get; set; }
        public DateTime DateTime { get; set; }
        public string TerminalId { get; set; }
        public string Account { get; set; }
        public string CardNumber { get; set; }
        public string CardInfo { get; set; }
        public decimal NetTotal { get; set; }
        public decimal TaxTotal { get; set; }
        public string Track1 { get; set; }
        public string Track2 { get; set; }
        public string Track3 { get; set; }
        public string Chip { get; set; }
        public decimal AmtAuthorized { get; set; }
        public decimal AmtPaid { get; set; }
        public int LayoutJournal { get; set; }
        public int LayoutReceipt { get; set; }
        public int LayoutCardInfo { get; set; }
        public int TerminationCode { get; set; }
        public int ErrorCode { get; set; }
        public decimal AmtRest { get; set; }
        public int TrxSeqNo { get; set; }
        public int TrxCount { get; set; }
        public int ArtDetailType { get; set; }
        public string PaymentType { get; set; }
        public int Language { get; set; }
        public string OidStornoOrigin { get; set; }
        public int StornoType { get; set; }
        public int IdStrRt { get; set; }
        public int IdWs { get; set; }
        public int IdopR { get; set; }
        public DateTime TsTmSRt { get; set; }
        public decimal AmtRnd { get; set; }
        public decimal AmtRcv { get; set; }
        public decimal AmtRtn { get; set; }
        public int RndType { get; set; }
        public string CardName { get; set; }
        public string AccountNo { get; set; }
        public int ForeignCny { get; set; }
        public int DscType { get; set; }
        public decimal DscRate { get; set; }
        public decimal DscAmt { get; set; }
        public decimal DscAmtTot { get; set; }
        public string AuthInfo { get; set; }
        public int HostDeliveryState { get; set; }
        public string DscTypeId { get; set; }
        public string DscTypeName { get; set; }
        public string DscRefNo { get; set; }
        public string MatchCode { get; set; }

        #endregion Public Properties
    }
}