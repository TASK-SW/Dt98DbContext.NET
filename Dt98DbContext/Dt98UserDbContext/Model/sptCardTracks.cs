//==================================================================================================
//  FILE        :   _sptCARDTRACKS.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     19.07.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("_sptCARDTRACKS")]
   public class sptCardTracks
   {
      #region Public Constructors

       public sptCardTracks()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Key]
       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_CARDPROFILE")]
       public string OidCardProfile { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TRACKPOS")]
       public int TrackPos { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("LOWVAL")]
       public int LOWVal { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("UPVAL")]
       public int UPVal { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CONDITION")]
       public int Condition { get; set; }


       #endregion Public Properties
   }
}
