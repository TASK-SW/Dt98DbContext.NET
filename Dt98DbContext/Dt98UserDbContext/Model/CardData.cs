namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("CARDDATA")]
    public class CardData
    {
        #region Public Constructors

        public CardData()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        [System.ComponentModel.DataAnnotations.Schema.Column("PAN")]
        public string PAN { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("PINMode")]
        public int PINMode { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("PIN")]
        public int PIN { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("MileageMode")]
        public int MileageMode { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("Mileage")]
        public int Mileage { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("ServiceCode")]
        public int ServiceCode { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("FuelLimit")]
        public int FuelLimit { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("PosDateElapse")]
        public int PosDateElapse { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("ErrorCountMax")]
        public int ErrorCountMax { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("ErrorCountCur")]
        public int ErrorCountCur { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("RecordState")]
        public int RecordState { get; set; }

        #endregion Public Properties
    }
}