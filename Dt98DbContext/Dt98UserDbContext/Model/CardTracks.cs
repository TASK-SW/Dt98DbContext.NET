using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("_sptCARDTRACKS")]
    public class CardTracks
    {
        #region Public Constructors

        public CardTracks()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
        public string Oid { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("OID_CARDPROFILE")]
        public string OidCardProfile { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("TRACKPOS")]
        public int TrackPos { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("LOWVAL")]
        public int LOWVal { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("UPVAL")]
        public int UPVal { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("CONDITION")]
        public int Condition { get; set; }

        #endregion Public Properties
    }
}