using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("ARTICLESUBGROUPS")]
   public class ArticlesUbGroups
   {
      #region Public Constructors

       public ArticlesUbGroups()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public string Oid { get; set; }

       [Column("OID_ARTGRP")]
       public string OidArtGrp { get; set; }

       [Column("ID")]
       public string Id { get; set; }

       [Column("NAME")]
       public string Name { get; set; }

       [Column("MIN_AGE")]
       public int Minage { get; set; }


       #endregion Public Properties
   }
}
