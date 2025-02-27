using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(Oid))]
   [Table("_sptGREYLISTS")]
   public class GreyLists
   {
      #region Public Constructors

       public GreyLists()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID")]
       public string Oid { get; set; }

       [Column("OID_TYPE")]
       public string OidType { get; set; }

       [Column("ID")]
       public int Id { get; set; }

       [Column("GENNO")]
       public string GenNo { get; set; }

       [Column("UPGENNO")]
       public string UpGenNo { get; set; }

       [Column("VERSION")]
       public string Version { get; set; }

       [Column("VALIDITY")]
       public int Validity { get; set; }

       [Column("DOWNLOADDATE")]
       public DateTime DownloadDate { get; set; }


       #endregion Public Properties
   }
}
