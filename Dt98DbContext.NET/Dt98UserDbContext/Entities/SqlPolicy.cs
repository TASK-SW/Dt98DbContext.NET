using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    //===[===PrimaryKey(nameof(Oid))]
   [Table("SQLPOLICY")]
   public class SqlPolicy
   {
      #region Public Constructors

       public SqlPolicy()
      {
      }

        #endregion Public Constructors

        #region Public Properties

        [Key]
        [Column("OID")]
       public string Oid { get; set; }

       [Column("POLTYPE")]
       public string PolType { get; set; }

       [Column("SERVER")]
       public string Server { get; set; }

       [Column("USER")]
       public string User { get; set; }

       [Column("PWD")]
       public string Pwd { get; set; }

       [Column("DATABASE")]
       public string DataBase { get; set; }

       [Column("DIRECTORY")]
       public string Directory { get; set; }

       [Column("OPTION")]
       public int Option { get; set; }

       [Column("ADDDATA")]
       public string AddData { get; set; }


       #endregion Public Properties
   }
}
