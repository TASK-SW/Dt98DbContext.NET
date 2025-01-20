using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(Oid))]
   [Table("_sctCARDTYPES")]
   public class CardTypes
   {
      #region Public Constructors

       public CardTypes()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID")]
       public string Oid { get; set; }

       [Column("ID")]
       public int Id { get; set; }

       [Column("NAME")]
       public string Name { get; set; }

       [Column("SHORTNAME")]
       public string ShortName { get; set; }

       [Column("IID")]
       public string IId { get; set; }

       [Column("CLSID")]
       public string ClsId { get; set; }

       [Column("IID_LAYOUT")]
       public string IIdLayout { get; set; }

       [Column("CLSID_LAYOUT")]
       public string ClsIdLayout { get; set; }

       [Column("OID_CARDBASETYPE")]
       public string OidCardBaseType { get; set; }

       [Column("IID_MANUALCARDDLG")]
       public string IIdManualCardDlg { get; set; }

       [Column("CLSID_MANUALCARDDLG")]
       public string ClsIdManualCardDlg { get; set; }


       #endregion Public Properties
   }
}
