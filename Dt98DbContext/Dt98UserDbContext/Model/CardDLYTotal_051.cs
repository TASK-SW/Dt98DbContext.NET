namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("CARDDLYTOTAL051")]
    public class CardDLYTotal_051
    {
        #region Public Constructors

        public CardDLYTotal_051()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        [System.ComponentModel.DataAnnotations.Schema.Column("PAN")]
        public string PAN { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("AMOUNT")]
        public decimal Amount { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("OUTDOORAMOUNT")]
        public decimal OutdoorAmount { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("EDITDATE")]
        public DateTime EditDate { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("DOP_INDOOR_AMT")]
        public decimal DOPIndoorAMT { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("DOP_INDOOR_CNT")]
        public int DOPIndoorCNT { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("DOP_OUTDOOR_AMT")]
        public decimal DOPOutdoorAMT { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("DOP_OUTDOOR_CNT")]
        public int DOPOutdoorCNT { get; set; }

        #endregion Public Properties
    }
}