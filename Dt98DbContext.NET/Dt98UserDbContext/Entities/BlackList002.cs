using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    [PrimaryKey(nameof(Oid))]
    [Table("BLACKLIST002")]
    public class BlackList002
    {
        #region Public Constructors

        public BlackList002()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        [Column("OID")]
        public string Oid { get; set; }

        [Column("OID_BLACKLIST")]
        public string OidBlackList { get; set; }

        [Column("LOWERPAN")]
        public string LowerPan { get; set; }

        [Column("UPPERPAN")]
        public string UpperPan { get; set; }

        [Column("WITHDRAW")]
        public int WithDraw { get; set; }

        [Column("MUTATOR")]
        public int Mutator { get; set; }

        #endregion Public Properties
    }
}