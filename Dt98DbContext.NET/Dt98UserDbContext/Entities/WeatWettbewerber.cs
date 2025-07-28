using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    //===[===PrimaryKey(nameof(Oid))]
   [Table("WEAT_Wettbewerber")]
   public class WeatWettbewerber
   {
      #region Public Constructors

       public WeatWettbewerber()
      {
      }

        #endregion Public Constructors

        #region Public Properties

        [Key]
        [Column("OID")]
       public string Oid { get; set; }

       [Column("Competitor")]
       public string Competitor { get; set; }

       [Column("CompanyNo")]
       public int CompanyNo { get; set; }

       [Column("Location")]
       public int Location { get; set; }

       [Column("Street")]
       public string Street { get; set; }

       [Column("ZIP")]
       public int Zip { get; set; }

       [Column("City")]
       public string City { get; set; }

       [Column("Product_01")]
       public int Product01 { get; set; }

       [Column("Product_02")]
       public int Product02 { get; set; }

       [Column("Product_03")]
       public int Product03 { get; set; }

       [Column("Product_04")]
       public int Product04 { get; set; }

       [Column("Product_05")]
       public int Product05 { get; set; }

       [Column("Product_06")]
       public int Product06 { get; set; }

       [Column("Product_07")]
       public int Product07 { get; set; }

       [Column("Product_08")]
       public int Product08 { get; set; }

       [Column("Product_09")]
       public int Product09 { get; set; }

       [Column("Product_10")]
       public int Product10 { get; set; }

       [Column("Product_11")]
       public int Product11 { get; set; }

       [Column("Product_12")]
       public int Product12 { get; set; }

       [Column("Product_13")]
       public int Product13 { get; set; }

       [Column("Product_14")]
       public int Product14 { get; set; }

       [Column("Product_15")]
       public int Product15 { get; set; }


       #endregion Public Properties
   }
}
