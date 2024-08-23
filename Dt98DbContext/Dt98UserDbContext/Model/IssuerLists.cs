using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("ISSUERLISTS")]
   public class IssuerLists
   {
      #region Public Constructors

       public IssuerLists()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public string Oid { get; set; }

       [Column("DT_VERSION")]
       public int DtVersion { get; set; }

       [Column("DT_LASTUPDATE")]
       public DateTime DtLastUpdate { get; set; }


       #endregion Public Properties
   }
}
