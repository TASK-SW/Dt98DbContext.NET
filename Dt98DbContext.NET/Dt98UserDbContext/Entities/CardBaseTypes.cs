using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    [PrimaryKey(nameof(Oid))]
    [Table("_sctCARDBASETYPES")]
    public class CardBaseTypes
    {
        #region Public Constructors

        public CardBaseTypes()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        [Column("OID")]
        public string Oid { get; set; }

        [Column("NAME")]
        public string Name { get; set; }

        #endregion Public Properties
    }
}