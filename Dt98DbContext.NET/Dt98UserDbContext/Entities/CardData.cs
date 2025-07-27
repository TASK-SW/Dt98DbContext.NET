using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    [PrimaryKey(nameof(Pan))]
    [Table("CARDDATA")]
    public class CardData
    {
        #region Public Constructors

        public CardData()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        [Column("PAN")]
        public string Pan { get; set; }

        [Column("PINMode")]
        public int PinMode { get; set; }

        [Column("PIN")]
        public int Pin { get; set; }

        [Column("MileageMode")]
        public int MileageMode { get; set; }

        [Column("Mileage")]
        public int Mileage { get; set; }

        [Column("ServiceCode")]
        public int ServiceCode { get; set; }

        [Column("FuelLimit")]
        public int FuelLimit { get; set; }

        [Column("PosDateElapse")]
        public int PosDateElapse { get; set; }

        [Column("ErrorCountMax")]
        public int ErrorCountMax { get; set; }

        [Column("ErrorCountCur")]
        public int ErrorCountCur { get; set; }

        [Column("RecordState")]
        public int RecordState { get; set; }

        #endregion Public Properties
    }
}