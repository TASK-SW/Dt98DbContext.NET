//==================================================================================================
//  FILE        :   DatacomOnlineCards.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("DatacomOnlineCards")]
   public class DatacomOnlineCards
   {
      #region Public Constructors

       public DatacomOnlineCards()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("TrackNo")]
       public int TrackNo { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CardId")]
       public string CardId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("RecordState")]
       public int RecordState { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ApplicationId")]
       public string ApplicationId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OnlineCheckIndoor")]
       public int OnlineCheckIndoor { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OnlineCheckOutdoor")]
       public int OnlineCheckOutdoor { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OnlinePresetOutdoor")]
       public decimal OnlinePresetOutdoor { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DownOptionLimitIndoor")]
       public decimal DownOptionLimitIndoor { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DownOptionLimitOutdoor")]
       public decimal DownOptionLimitOutdoor { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DownOptionTransactionCount")]
       public int DownOptionTransactionCount { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DownOptionCheckBlacklist")]
       public int DownOptionCheckBlacklist { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OnlineFloorLimit")]
       public decimal OnlineFloorLimit { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("AuthorizationHost1Id")]
       public int AuthorizationHost1Id { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("AuthorizationHost2Id")]
       public int AuthorizationHost2Id { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TdFileOnlineInformation")]
       public int TdFileOnlineInformation { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OnlineSiteId")]
       public string OnlineSiteId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OlisVersion")]
       public int OlisVersion { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("SiteIdOlis1P")]
       public int SiteIdOlis1P { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CheckLuhn")]
       public int CheckLuhn { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("MinumumPanLength")]
       public int MinumumPanLength { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("MaximumPanLength")]
       public int MaximumPanLength { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ExpirationDatePosition")]
       public int ExpirationDatePosition { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("IssuerId")]
       public int IssuerId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("SignatureAllowed")]
       public int SignatureAllowed { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("BlacklistId")]
       public int BlacklistId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DCCQuery")]
       public int DccQuery { get; set; }


       #endregion Public Properties
   }
}
