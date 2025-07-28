
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class PosDataXmlPdfExportOrdersConfiguration : IEntityTypeConfiguration<PosDataXmlPdfExportOrders>
    {
        public void Configure(EntityTypeBuilder<PosDataXmlPdfExportOrders> builder)
        {
            builder.ToTable("POSDataXmlPdfExportOrders");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.OrderDateTime).HasColumnName("OrderDateTime");
            builder.Property(e => e.TransactionDateTime).HasColumnName("TransactionDateTime");
            builder.Property(e => e.CreateDateTime).HasColumnName("CreateDateTime");
            builder.Property(e => e.SequenceNumber).HasColumnName("SequenceNumber");
            builder.Property(e => e.ReportName).HasColumnName("ReportName");
            builder.Property(e => e.ReceiptText1).HasColumnName("ReceiptText1");
            builder.Property(e => e.ReceiptText2).HasColumnName("ReceiptText2");
            builder.Property(e => e.IsOutDoor).HasColumnName("IsOutDoor");
            builder.Property(e => e.CashierName).HasColumnName("CashierName");
            builder.Property(e => e.XmlExport).HasColumnName("XMLExport");
            builder.Property(e => e.PdfExport).HasColumnName("PDFExport");
            builder.Property(e => e.ExportPath).HasColumnName("ExportPath");
            builder.Property(e => e.ExportCardType).HasColumnName("ExportCardType");
            builder.Property(e => e.OrderStatus).HasColumnName("OrderStatus");
            builder.Property(e => e.OrderType).HasColumnName("OrderType");
            builder.Property(e => e.XmlFileName).HasColumnName("XmlFileName");
            builder.Property(e => e.PdfFileName).HasColumnName("PdfFileName");
            builder.Property(e => e.Md5XMl).HasColumnName("MD5XMl");
            builder.Property(e => e.Md5Pdf).HasColumnName("MD5Pdf");
            builder.Property(e => e.ErrorCode).HasColumnName("ErrorCode");
            builder.Property(e => e.Errormessage).HasColumnName("Errormessage");
        }
    }
}
