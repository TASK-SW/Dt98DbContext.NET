//==================================================================================================
//  FILE        :   _sptOPTOTAL_BASEMATRIX.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     19.07.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("_sptOPTOTAL_BASEMATRIX")]
   public class sptOPTotalBaseMatrix
   {
      #region Public Constructors

       public sptOPTotalBaseMatrix()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Key]
       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public int Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_PRODUCT_ID")]
       public string DTProductId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_TRANSACTION_ID")]
       public string DTTransactionId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_TYPE")]
       public int DTType { get; set; }


       #endregion Public Properties
   }
}
