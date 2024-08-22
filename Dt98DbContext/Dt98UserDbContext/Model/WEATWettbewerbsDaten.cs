//==================================================================================================
//  FILE        :   WEAT_WettbewerbsDaten.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("WEAT_WettbewerbsDaten")]
   public class WEATWettbewerbsDaten
   {
      #region Public Constructors

       public WEATWettbewerbsDaten()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_WETTBEWERBER")]
       public string OidWettBewerber { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ProductId")]
       public int ProductId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("UnitPrice")]
       public decimal UnitPrice { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DateTime")]
       public DateTime DateTime { get; set; }


       #endregion Public Properties
   }
}
