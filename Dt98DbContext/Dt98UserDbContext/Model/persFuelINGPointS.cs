//==================================================================================================
//  FILE        :   _persFUELINGPOINTS.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("_persFUELINGPOINTS")]
   public class persFuelINGPointS
   {
      #region Public Constructors

       public persFuelINGPointS()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_FUELSALE")]
       public string OidFuelSale { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CONTROLSTATE")]
       public int ControlState { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("LASTERROR")]
       public int LastError { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ERRORCOUNT")]
       public int ErrorCount { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CURRENTNOZZLE")]
       public int CurrentNozzle { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("LT_NUMMERATEUR")]
       public int LTNUMMERateUR { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("LT_VOLUME")]
       public int LTVolume { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("LT_AMOUNT")]
       public int LTAmount { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("LT_NOZZLE")]
       public int LTNozzle { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PS_STATE")]
       public int PSState { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PS_ERROR")]
       public int PSError { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PS_COUNTER1")]
       public int PSCountER_1 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PS_COUNTER2")]
       public int PSCountER_2 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PS_COUNTER3")]
       public int PSCountER_3 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PS_COUNTER4")]
       public int PSCountER_4 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PS_NUMMERATEUR")]
       public int PSNUMMERateUR { get; set; }


       #endregion Public Properties
   }
}
