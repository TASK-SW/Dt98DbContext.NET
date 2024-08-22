//==================================================================================================
//  FILE        :   EANCODES.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("EANCODES")]
   public class EanCodes
   {
      #region Public Constructors

       public EanCodes()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("EANCODE")]
       public string EanCode { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_ARTICLE")]
       public string OidArticle { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("SALES_PRICE")]
       public decimal SalesPrice { get; set; }


       #endregion Public Properties
   }
}
