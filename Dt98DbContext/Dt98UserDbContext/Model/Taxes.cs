using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("TAXES")]
   public class Taxes
   {
      #region Public Constructors

       public Taxes()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
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
