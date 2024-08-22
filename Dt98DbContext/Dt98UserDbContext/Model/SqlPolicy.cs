//==================================================================================================
//  FILE        :   SQLPOLICY.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("SQLPOLICY")]
   public class SqlPolicy
   {
      #region Public Constructors

       public SqlPolicy()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("POLTYPE")]
       public string POLType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("SERVER")]
       public string Server { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("USER")]
       public string User { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PWD")]
       public string PWD { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DATABASE")]
       public string DataBase { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DIRECTORY")]
       public string Directory { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OPTION")]
       public int Option { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ADDDATA")]
       public string AddData { get; set; }


       #endregion Public Properties
   }
}
