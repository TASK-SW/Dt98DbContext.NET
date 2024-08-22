//==================================================================================================
//  FILE        :   _sptCARDDATACOM.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     19.07.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("_sptCARDDATACOM")]
   public class sptCardDataCom
   {
      #region Public Constructors

       public sptCardDataCom()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Key]
       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_CARD_TYPE_ID")]
       public string DTCardTypeId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_ROUND_OPTOTAL")]
       public int DTRoundOPTotal { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_ROUND_TRX")]
       public int DTRoundTRX { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_XMIT_LIMIT_OUTDOOR")]
       public int DTXMITLimitOutdoor { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_LIMIT_OUTDOOR")]
       public int DTLimitOutdoor { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_LIMIT_TOTAL")]
       public int DTLimitTotal { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_ACCEPTANCE")]
       public int DTAcceptance { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_XMIT_ONLINE_AUTH")]
       public int DTXMITONLINEAuth { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_ONLINE_AUTH")]
       public int DTONLINEAuth { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_XMIT_PIN_AUTH")]
       public int DTXMITPINAuth { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_PIN_AUTH")]
       public int DTPINAuth { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PAN_STRIP_BLACKLIST")]
       public int PANStripBlackList { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PAN_STRIP_TRANSACT")]
       public int PANStripTransACT { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TRXDELIVMASK")]
       public int TRXDelivMask { get; set; }


       #endregion Public Properties
   }
}
