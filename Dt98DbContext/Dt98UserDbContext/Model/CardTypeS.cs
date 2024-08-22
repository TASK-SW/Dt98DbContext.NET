//==================================================================================================
//  FILE        :   _sctCARDTYPES.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("_sctCARDTYPES")]
   public class CardTypeS
   {
      #region Public Constructors

       public CardTypeS()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ID")]
       public int Id { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("NAME")]
       public string Name { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("SHORTNAME")]
       public string ShortName { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("IID")]
       public string IId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CLSID")]
       public string CLSId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("IID_LAYOUT")]
       public string IIdLayout { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CLSID_LAYOUT")]
       public string CLSIdLayout { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_CARDBASETYPE")]
       public string OidCardBaseType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("IID_MANUALCARDDLG")]
       public string IIdManualCardDLG { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CLSID_MANUALCARDDLG")]
       public string CLSIdManualCardDLG { get; set; }


       #endregion Public Properties
   }
}
