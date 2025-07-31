using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class JournalKassenSich
    {
        #region Private Fields

        private JournalHeader _header;

        #endregion Private Fields

        #region Private Properties

        private ILazyLoader LazyLoader { get; set; }

        #endregion Private Properties

        #region Public Constructors

        public JournalKassenSich()
        {
        }

        public JournalKassenSich(ILazyLoader lazyLoader)
        {
            LazyLoader = lazyLoader;
        }
        #endregion Public Constructors

        #region Public Properties

        public string OidJournal { get; set; }
        public JournalHeader Header
        {
            get => LazyLoader.Load(this, ref _header);
            set => _header = value;
        }
        public string ProcessType { get; set; }
        public string ProcessData { get; set; }
        public long? TransactionNumber { get; set; }
        public long? SignatureCounter { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? LogTime { get; set; }
        public string SignAlgorithm { get; set; }
        public string LogTimeFormat { get; set; }
        public string Signature { get; set; }
        public string PublicKey { get; set; }
        public string TseSerialNumber { get; set; }
        public string SignatureError { get; set; }

        #endregion Public Properties
    }
}