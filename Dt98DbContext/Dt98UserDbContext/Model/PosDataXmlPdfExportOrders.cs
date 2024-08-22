//==================================================================================================
//  FILE        :   POSDataXmlPdfExportOrders.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("POSDataXmlPdfExportOrders")]
   public class PosDataXmlPdfExportOrders
   {
      #region Public Constructors

       public PosDataXmlPdfExportOrders()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("ID")]
       public string Id { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OrderDateTime")]
       public DateTime OrderDateTime { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TransactionDateTime")]
       public DateTime TransactionDateTime { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CreateDateTime")]
       public DateTime CreateDateTime { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("SequenceNumber")]
       public int SequenceNumber { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ReportName")]
       public string ReportName { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ReceiptText1")]
       public string ReceiptText1 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ReceiptText2")]
       public string ReceiptText2 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("IsOutDoor")]
       public int IsOutDoor { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CashierName")]
       public string CashierName { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("XMLExport")]
       public int XMLExport { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PDFExport")]
       public int PDFExport { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ExportPath")]
       public string ExportPath { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ExportCardType")]
       public int ExportCardType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OrderStatus")]
       public int OrderStatus { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OrderType")]
       public int OrderType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("XmlFileName")]
       public string XmlFileName { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PdfFileName")]
       public string PdfFileName { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("MD5XMl")]
       public string MD5XMl { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("MD5Pdf")]
       public string MD5Pdf { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ErrorCode")]
       public int ErrorCode { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Errormessage")]
       public string Errormessage { get; set; }


       #endregion Public Properties
   }
}
