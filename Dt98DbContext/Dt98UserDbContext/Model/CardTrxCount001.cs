//==================================================================================================
//  FILE        :   CARDTRXCOUNT001.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("CARDTRXCOUNT001")]
    public class CardTrxCount001
    {
        #region Public Constructors

        public CardTRXCount_001()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        [System.ComponentModel.DataAnnotations.Schema.Column("PAN")]
        public string PAN { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("COUNT")]
        public int Count { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("EDITDATE")]
        public DateTime EditDate { get; set; }

        #endregion Public Properties
    }
}