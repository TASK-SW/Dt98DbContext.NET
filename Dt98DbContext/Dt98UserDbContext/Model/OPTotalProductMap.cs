//==================================================================================================
//  FILE        :   _sptOPTOTAL_PRODUCTMAP.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("_sptOPTOTAL_PRODUCTMAP")]
   public class OPTotalProductMap
   {
      #region Public Constructors

       public OPTotalProductMap()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public int Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ARTICLE_ID")]
       public string ArticleId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PRODUCT_ID")]
       public string ProductId { get; set; }


       #endregion Public Properties
   }
}
