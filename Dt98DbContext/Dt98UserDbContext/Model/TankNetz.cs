//==================================================================================================
//  FILE        :   TankNetz.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("TankNetz")]
   public class TankNetz
   {
      #region Public Constructors

       public TankNetz()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DateTime")]
       public DateTime DateTime { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("JournalId")]
       public int JournalId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("StationId")]
       public int StationId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TerminalId")]
       public int TerminalId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FirstCard")]
       public string FirstCard { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("SecondCard")]
       public int SecondCard { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Mileage")]
       public int Mileage { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("AddInfo")]
       public int AddInfo { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ArticleId")]
       public int ArticleId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FPId")]
       public int FPId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ProductType")]
       public int ProductType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Quantity")]
       public decimal Quantity { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("UnitPrice")]
       public decimal UnitPrice { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Amount")]
       public decimal Amount { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("Nummerator")]
       public int Nummerator { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PIN")]
       public int PIN { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ArticleName")]
       public string ArticleName { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TraceNo")]
       public string TraceNo { get; set; }


       #endregion Public Properties
   }
}
