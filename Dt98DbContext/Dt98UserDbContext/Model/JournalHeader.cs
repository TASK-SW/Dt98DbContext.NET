//==================================================================================================
//  FILE        :   JOURNALHEADER.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("JOURNALHEADER")]
   public class JournalHeader
   {
      #region Public Constructors

       public JournalHeader()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("RECTYPE")]
       public int RECType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("JOURNALID")]
       public int JournalId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DATETIME")]
       public DateTime DateTime { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TERMINALID")]
       public string TerminalId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ACCOUNT")]
       public string Account { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CARDNUMBER")]
       public string CardNumber { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CARDINFO")]
       public string CardInfo { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("NETTOTAL")]
       public decimal NetTotal { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TAXTOTAL")]
       public decimal TAXTotal { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TRACK_1")]
       public string Track1 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TRACK_2")]
       public string Track2 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TRACK_3")]
       public string Track3 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CHIP")]
       public string Chip { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("AMT_AUTHORIZED")]
       public decimal AMTAuthorized { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("AMT_PAID")]
       public decimal AMTPaid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("LAYOUTJOURNAL")]
       public int LayoutJournal { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("LAYOUTRECEIPT")]
       public int LayoutReceipt { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("LAYOUTCARDINFO")]
       public int LayoutCardInfo { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TERMINATIONCODE")]
       public int TerminationCode { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ERRORCODE")]
       public int ErrorCode { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("AMT_REST")]
       public decimal Amtrest { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TRXSEQNO")]
       public int Trxseqno { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TRXCOUNT")]
       public int TRXCount { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ARTDETAILTYPE")]
       public int ArtDetailType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PAYMENTTYPE")]
       public string PaymentType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("LANGUAGE")]
       public int Language { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_STORNO_ORIGIN")]
       public string OidStornoOrigin { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("STORNOTYPE")]
       public int StornoType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ID_STR_RT")]
       public int IdSTRRT { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ID_WS")]
       public int IdWS { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ID_OPR")]
       public int IdOPR { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TS_TM_SRT")]
       public DateTime Tstmsrt { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("AMT_RND")]
       public decimal Amtrnd { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("AMT_RCV")]
       public decimal Amtrcv { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("AMT_RTN")]
       public decimal Amtrtn { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("RND_TYPE")]
       public int RNDType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CARD_NAME")]
       public string CardName { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ACCOUNT_NO")]
       public string AccountNO { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FOREIGN_CNY")]
       public int ForeignCNY { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DSC_TYPE")]
       public int DSCType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DSC_RATE")]
       public decimal DSCRate { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DSC_AMT")]
       public decimal Dscamt { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DSC_AMTTOT")]
       public decimal Dscamttot { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("AUTH_INFO")]
       public string AuthInfo { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("HOSTDELIVERYSTATE")]
       public int HostDeliveryState { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DSC_TYPE_ID")]
       public string DSCTypeId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DSC_TYPE_NAME")]
       public string DSCTypeName { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DSC_REF_NO")]
       public string Dscrefno { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("MATCH_CODE")]
       public string MatchCode { get; set; }


       #endregion Public Properties
   }
}
