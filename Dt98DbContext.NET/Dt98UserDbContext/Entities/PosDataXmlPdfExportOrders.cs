using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    [PrimaryKey(nameof(Id))]
   [Table("POSDataXmlPdfExportOrders")]
   public class PosDataXmlPdfExportOrders
   {
      #region Public Constructors

       public PosDataXmlPdfExportOrders()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("ID")]
       public string Id { get; set; }

       [Column("OID")]
       public string Oid { get; set; }

       [Column("OrderDateTime")]
       public DateTime OrderDateTime { get; set; }

       [Column("TransactionDateTime")]
       public DateTime TransactionDateTime { get; set; }

       [Column("CreateDateTime")]
       public DateTime CreateDateTime { get; set; }

       [Column("SequenceNumber")]
       public int SequenceNumber { get; set; }

       [Column("ReportName")]
       public string ReportName { get; set; }

       [Column("ReceiptText1")]
       public string ReceiptText1 { get; set; }

       [Column("ReceiptText2")]
       public string ReceiptText2 { get; set; }

       [Column("IsOutDoor")]
       public int IsOutDoor { get; set; }

       [Column("CashierName")]
       public string CashierName { get; set; }

       [Column("XMLExport")]
       public int XmlExport { get; set; }

       [Column("PDFExport")]
       public int PdfExport { get; set; }

       [Column("ExportPath")]
       public string ExportPath { get; set; }

       [Column("ExportCardType")]
       public int ExportCardType { get; set; }

       [Column("OrderStatus")]
       public int OrderStatus { get; set; }

       [Column("OrderType")]
       public int OrderType { get; set; }

       [Column("XmlFileName")]
       public string XmlFileName { get; set; }

       [Column("PdfFileName")]
       public string PdfFileName { get; set; }

       [Column("MD5XMl")]
       public string Md5XMl { get; set; }

       [Column("MD5Pdf")]
       public string Md5Pdf { get; set; }

       [Column("ErrorCode")]
       public int ErrorCode { get; set; }

       [Column("Errormessage")]
       public string Errormessage { get; set; }


       #endregion Public Properties
   }
}
