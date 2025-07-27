using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    [PrimaryKey(nameof(Oid))]
    [Table("_sptCARDFIELDS")]
    public class CardFields
    {
        #region Public Constructors

        public CardFields()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        [Column("OID")]
        public string Oid { get; set; }

        [Column("OID_TYPE")]
        public string OidType { get; set; }

        [Column("FIELDID")]
        public int FieldId { get; set; }

        [Column("POSITION")]
        public int Position { get; set; }

        [Column("LENGTH")]
        public int Length { get; set; }

        [Column("CHECKOPTION")]
        public int CheckOption { get; set; }

        [Column("MINSIZE")]
        public int MinSize { get; set; }

        [Column("MAXSIZE")]
        public int MaxSize { get; set; }

        [Column("TEXTID")]
        public int TextId { get; set; }

        #endregion Public Properties
    }
}