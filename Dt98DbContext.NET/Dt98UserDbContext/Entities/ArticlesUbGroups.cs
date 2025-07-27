using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    [PrimaryKey(nameof(Oid))]
    [Table("ARTICLESUBGROUPS")]
    public class ArticlesUbGroups
    {
        #region Public Constructors

        public ArticlesUbGroups()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        [Column("OID")]
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