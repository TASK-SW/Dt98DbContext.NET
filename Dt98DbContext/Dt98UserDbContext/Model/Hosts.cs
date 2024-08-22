//==================================================================================================
//  FILE        :   _sptHOSTS.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("_sptHOSTS")]
   public class Hosts
   {
      #region Public Constructors

       public Hosts()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_TYPE")]
       public string OidType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_NAME")]
       public string DTName { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_STATION_ID")]
       public string DTStationId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_ISSUERLIST_OID")]
       public string DTISSUERListOid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_FILEID_MSD")]
       public string DTFileIdMSD { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_SHORTCUT")]
       public string DTShortCut { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_APPLICATION_ID")]
       public string DTApplicationId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_INPATH")]
       public string DTINPath { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_OUTPATH")]
       public string DTOUTPath { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_SLUMPATH")]
       public string DTSLUMPath { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_CARDHANDLING_OID")]
       public string DTCardHandlingOid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_CHECK_SYSTEM")]
       public int DTCheckSystem { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_CHECK_ACCEPTANCE")]
       public int DTCheckAcceptance { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_DELIVER_OPTOTAL")]
       public int DTDelivEROPTotal { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_LOGIN_NAME")]
       public string DTLOGINName { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_APPLICATION_TYPE")]
       public string DTApplicationType { get; set; }


       #endregion Public Properties
   }
}
