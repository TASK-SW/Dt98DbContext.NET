namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("ARTICLES")]
    public class Articles
    {
        #region Public Constructors

        public Articles()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
        public string Oid { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("OID_ARTSUBGRP")]
        public string OidArtSubGrp { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("OID_TAX")]
        public string OidTAX { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("ID")]
        public string Id { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("EANCODE")]
        public string EanCode { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("NAME")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("SHORTNAME")]
        public string ShortName { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("RECEIPTTEXT")]
        public string ReceiptText { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("SALES_PRICE")]
        public decimal SalesPrice { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("SALES_UNIT")]
        public int SalesUnit { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("SALES_QUANTITY")]
        public decimal SalesQuantity { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("NORM_UNIT")]
        public int NormUnit { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("NORM_QUANTITY")]
        public decimal NormQuantity { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("NORM_PRICE")]
        public decimal NormPrice { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("VOUCHER_ENABLED")]
        public int VoucherENABLED { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("VOUCHER_VALID_FROM")]
        public DateTime VoucherValIdFrom { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("VOUCHER_VALID_TO")]
        public DateTime VoucherValIdTO { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("VOUCHER_VALID_DAYS")]
        public int VoucherValIdDayS { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("VOUCHER_THRESHOLD")]
        public int VoucherTHRESHOLD { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("VOUCHER_MIN_AMOUNT")]
        public decimal VoucherMinAmount { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("VOUCHER_DSC_PER_LITER")]
        public decimal VoucherDSCPERLITER { get; set; }

        #endregion Public Properties
    }
}