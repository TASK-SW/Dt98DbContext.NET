using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("DatacomOnlineCards")]
   public class DatacomOnlineCards
   {
      #region Public Constructors

       public DatacomOnlineCards()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("TrackNo")]
       public int TrackNo { get; set; }

       [Key, Column(Order = 1)]
       //[Column("CardId")]
       public string CardId { get; set; }

       [Key, Column(Order = 2)]
       //[Column("RecordState")]
       public int RecordState { get; set; }

       [Key, Column(Order = 3)]
       //[Column("ApplicationId")]
       public string ApplicationId { get; set; }

       [Column("OnlineCheckIndoor")]
       public int OnlineCheckIndoor { get; set; }

       [Column("OnlineCheckOutdoor")]
       public int OnlineCheckOutdoor { get; set; }

       [Column("OnlinePresetOutdoor")]
       public decimal OnlinePresetOutdoor { get; set; }

       [Column("DownOptionLimitIndoor")]
       public decimal DownOptionLimitIndoor { get; set; }

       [Column("DownOptionLimitOutdoor")]
       public decimal DownOptionLimitOutdoor { get; set; }

       [Column("DownOptionTransactionCount")]
       public int DownOptionTransactionCount { get; set; }

       [Column("DownOptionCheckBlacklist")]
       public int DownOptionCheckBlacklist { get; set; }

       [Column("OnlineFloorLimit")]
       public decimal OnlineFloorLimit { get; set; }

       [Column("AuthorizationHost1Id")]
       public int AuthorizationHost1Id { get; set; }

       [Column("AuthorizationHost2Id")]
       public int AuthorizationHost2Id { get; set; }

       [Column("TdFileOnlineInformation")]
       public int TdFileOnlineInformation { get; set; }

       [Column("OnlineSiteId")]
       public string OnlineSiteId { get; set; }

       [Column("OlisVersion")]
       public int OlisVersion { get; set; }

       [Column("SiteIdOlis1P")]
       public int SiteIdOlis1P { get; set; }

       [Column("CheckLuhn")]
       public int CheckLuhn { get; set; }

       [Column("MinumumPanLength")]
       public int MinumumPanLength { get; set; }

       [Column("MaximumPanLength")]
       public int MaximumPanLength { get; set; }

       [Column("ExpirationDatePosition")]
       public int ExpirationDatePosition { get; set; }

       [Column("IssuerId")]
       public int IssuerId { get; set; }

       [Column("SignatureAllowed")]
       public int SignatureAllowed { get; set; }

       [Column("BlacklistId")]
       public int BlacklistId { get; set; }

       [Column("DCCQuery")]
       public int DccQuery { get; set; }


       #endregion Public Properties
   }
}
