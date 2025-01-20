using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(Id))]
   [Table("_sptTERMINATIONCODES")]
   public class TerminationCodes
   {
      #region Public Constructors

       public TerminationCodes()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("ID")]
       public int Id { get; set; }

       [Column("CODE01")]
       public int Code01 { get; set; }

       [Column("CODE02")]
       public int Code02 { get; set; }

       [Column("CODE03")]
       public int Code03 { get; set; }

       [Column("CODE04")]
       public int Code04 { get; set; }

       [Column("CODE05")]
       public int Code05 { get; set; }

       [Column("CODE06")]
       public int Code06 { get; set; }

       [Column("CODE07")]
       public int Code07 { get; set; }

       [Column("CODE08")]
       public int Code08 { get; set; }

       [Column("CODE09")]
       public int Code09 { get; set; }

       [Column("CODE10")]
       public int Code10 { get; set; }

       [Column("CODE11")]
       public int Code11 { get; set; }

       [Column("CODE12")]
       public int Code12 { get; set; }

       [Column("CODE13")]
       public int Code13 { get; set; }

       [Column("CODE14")]
       public int Code14 { get; set; }

       [Column("CODE15")]
       public int Code15 { get; set; }

       [Column("CODE16")]
       public int Code16 { get; set; }

       [Column("CODE17")]
       public int Code17 { get; set; }

       [Column("CODE18")]
       public int Code18 { get; set; }

       [Column("CODE19")]
       public int Code19 { get; set; }

       [Column("CODE20")]
       public int Code20 { get; set; }


       #endregion Public Properties
   }
}
