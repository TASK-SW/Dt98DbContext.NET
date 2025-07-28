namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class BlackList001
    {
        #region Public Constructors

        public BlackList001()
        { }

        #endregion Public Constructors

        #region Public Properties

        public string Oid { get; set; }

        public string OidBlackList { get; set; }

        public string LowerPan { get; set; }

        public string UpperPan { get; set; }

        public int WithDraw { get; set; }

        public int Mutator { get; set; }

        #endregion Public Properties
    }
}