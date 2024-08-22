//==================================================================================================
//  FILE        :   WEAT_Wettbewerber.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("WEAT_Wettbewerber")]
   public class WEATWettbewerber
   {
      #region Public Constructors

       public WEATWettbewerber()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Competitor")]
       public string Competitor { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CompanyNo")]
       public int CompanyNo { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Location")]
       public int Location { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Street")]
       public string Street { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ZIP")]
       public int ZIP { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("City")]
       public string City { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Product_01")]
       public int Product_01 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Product_02")]
       public int Product_02 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Product_03")]
       public int Product_03 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Product_04")]
       public int Product_04 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Product_05")]
       public int Product_05 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Product_06")]
       public int Product_06 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Product_07")]
       public int Product_07 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Product_08")]
       public int Product_08 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Product_09")]
       public int Product_09 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Product_10")]
       public int Product_10 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Product_11")]
       public int Product_11 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Product_12")]
       public int Product_12 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Product_13")]
       public int Product_13 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Product_14")]
       public int Product_14 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Product_15")]
       public int Product_15 { get; set; }


       #endregion Public Properties
   }
}
