using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("_sctNORMUNITS")]
   public class NormUnits
   {
      #region Public Constructors

       public NormUnits()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("ID")]
       public int Id { get; set; }

       [Column("NORM_UNIT_NAME")]
       public string NormUnitName { get; set; }

       [Column("NORM_BASE_QUANTITY")]
       public int NormBaseQuantity { get; set; }


       #endregion Public Properties
   }
}
