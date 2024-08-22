//==================================================================================================
//  FILE        :   _sptTERMINATIONCODES.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     19.07.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("_sptTERMINATIONCODES")]
   public class sptTerminationCodes
   {
      #region Public Constructors

       public sptTerminationCodes()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Key]
       [System.ComponentModel.DataAnnotations.Schema.Column("ID")]
       public int Id { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CODE01")]
       public int Code_01 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CODE02")]
       public int Code_02 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CODE03")]
       public int Code_03 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CODE04")]
       public int Code_04 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CODE05")]
       public int Code_05 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CODE06")]
       public int Code_06 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CODE07")]
       public int Code_07 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CODE08")]
       public int Code_08 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CODE09")]
       public int Code_09 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CODE10")]
       public int Code_10 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CODE11")]
       public int Code_11 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CODE12")]
       public int Code_12 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CODE13")]
       public int Code_13 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CODE14")]
       public int Code_14 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CODE15")]
       public int Code_15 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CODE16")]
       public int Code_16 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CODE17")]
       public int Code_17 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CODE18")]
       public int Code_18 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CODE19")]
       public int Code_19 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CODE20")]
       public int Code_20 { get; set; }


       #endregion Public Properties
   }
}
