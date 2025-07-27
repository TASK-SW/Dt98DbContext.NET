using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    [PrimaryKey(nameof(Oid))]
   [Table("TAXES")]
   public class Taxes
   {
      #region Public Constructors

       public Taxes()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID")]
       public string Oid { get; set; }

       [Column("ID")]
       public int Id { get; set; }

       [Column("NAME")]
       public string Name { get; set; }

       [Column("TAX")]
       public decimal Tax { get; set; }


       #endregion Public Properties
   }
}
