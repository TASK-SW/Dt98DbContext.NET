using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class Receipts
    {
        #region Private Fields

        private JournalHeader _header;

        #endregion Private Fields

        #region Private Properties

        private ILazyLoader LazyLoader { get; set; }

        #endregion Private Properties

        #region Public Constructors

        public Receipts()
        {
        }

        public Receipts(ILazyLoader lazyLoader)
        {
            LazyLoader = lazyLoader;
        }

        #endregion Public Constructors

        #region Public Properties

        public string OidReceipt { get; set; }

        public JournalHeader Header
        {
            get => LazyLoader.Load(this, ref _header);
            set => _header = value;
        }

        public string OidCardType { get; set; }

        public string OidTerminal { get; set; }

        public int TerminalType { get; set; }

        public string Pan { get; set; }

        public int PrintCount { get; set; }

        public DateTime? DateStore { get; set; }

        public DateTime? DatePrint { get; set; }
        public string ReceiptText { get; set; }

        public string ExtraData { get; set; }
        public int PrinterWidth { get; set; }

        public string WmFormat { get; set; }

        public string Pan2 { get; set; }

        public string Pan3 { get; set; }

        public string Pan4 { get; set; }

        public string Pan5 { get; set; }

        #endregion Public Properties
    }
}