using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class PosDataXmlPdfExportOrders
    {
        #region Public Constructors

        public PosDataXmlPdfExportOrders()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public string Id { get; set; }
        public string Oid { get; set; }
        public DateTime? OrderDateTime { get; set; }
        public DateTime? TransactionDateTime { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public int? SequenceNumber { get; set; }
        public string ReportName { get; set; }
        public string ReceiptText1 { get; set; }
        public string ReceiptText2 { get; set; }
        public int? IsOutDoor { get; set; }
        public string CashierName { get; set; }
        public int? XmlExport { get; set; }
        public int? PdfExport { get; set; }
        public string ExportPath { get; set; }
        public int? ExportCardType { get; set; }
        public int? OrderStatus { get; set; }
        public int? OrderType { get; set; }
        public string XmlFileName { get; set; }
        public string PdfFileName { get; set; }
        public string Md5XMl { get; set; }
        public string Md5Pdf { get; set; }
        public int? ErrorCode { get; set; }
        public string Errormessage { get; set; }

        #endregion Public Properties
    }
}