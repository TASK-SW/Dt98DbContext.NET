namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Tests
{
    [TestClass()]
    public class Dt98UserContextFactoryTests
    {
        #region Public Methods

        [TestMethod()]
        public void GetDbContextTest()
        {
            Dt98UserContextFactory factory = new Dt98UserContextFactory(
                @"Server=localhost\SQL2014;Database=DT98User;User Id=sa;Password=E77lingen;Encrypt=false;TrustServerCertificate=true;");

            var db = factory.GetDbContext();

            var header = db.JournalHeader.FirstOrDefault(h => h.Oid == "{2D088B0B-A23D-4C99-9822-A7520B47F8C1}");
        }

        #endregion Public Methods
    }
}