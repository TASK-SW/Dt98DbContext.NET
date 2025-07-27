using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    [PrimaryKey(nameof(Oid))]
   [Table("_sptHOSTS")]
   public class Hosts
   {
      #region Public Constructors

       public Hosts()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID")]
       public string Oid { get; set; }

       [Column("OID_TYPE")]
       public string OidType { get; set; }

       [Column("DT_NAME")]
       public string DtName { get; set; }

       [Column("DT_STATION_ID")]
       public string DtStationId { get; set; }

       [Column("DT_ISSUERLIST_OID")]
       public string DtIssuerListOid { get; set; }

       [Column("DT_FILEID_MSD")]
       public string DtFileIdMsd { get; set; }

       [Column("DT_SHORTCUT")]
       public string DtShortCut { get; set; }

       [Column("DT_APPLICATION_ID")]
       public string DtApplicationId { get; set; }

       [Column("DT_INPATH")]
       public string DtInPath { get; set; }

       [Column("DT_OUTPATH")]
       public string DtOutPath { get; set; }

       [Column("DT_SLUMPATH")]
       public string DtSlumPath { get; set; }

       [Column("DT_CARDHANDLING_OID")]
       public string DtCardHandlingOid { get; set; }

       [Column("DT_CHECK_SYSTEM")]
       public int DtCheckSystem { get; set; }

       [Column("DT_CHECK_ACCEPTANCE")]
       public int DtCheckAcceptance { get; set; }

       [Column("DT_DELIVER_OPTOTAL")]
       public int DtDelivErOpTotal { get; set; }

       [Column("DT_LOGIN_NAME")]
       public string DtLoginName { get; set; }

       [Column("DT_APPLICATION_TYPE")]
       public string DtApplicationType { get; set; }


       #endregion Public Properties
   }
}
