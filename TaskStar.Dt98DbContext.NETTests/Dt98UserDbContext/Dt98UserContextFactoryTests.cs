using Microsoft.EntityFrameworkCore;

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
                @"Server=localhost\SQLEXPRESS;Database=DT98User_CityBonCard;User Id=sa;Password=E77lingen;Encrypt=false;TrustServerCertificate=true;");
                //@"Server=localhost\SQL2014;Database=DT98User_Limbach;User Id=sa;Password=E77lingen;Encrypt=false;TrustServerCertificate=true;");


            var db = factory.GetDbContext();

            var header = db.JournalHeader
                //.Include(h => h.Receipt)
                .FirstOrDefault(h => h.Oid == "{2D088B0B-A23D-4C99-9822-A7520B47F8C1}");

            var receipt = header.Receipt;

            var devices = db.DevConfig
                .Include(c => c.DevType)
                .Include(c => c.DevClass)
                .Include(c => c.DevSettings)
                .ThenInclude(s => s.ValType)
                .ToList();
        }

        #endregion Public Methods
    }
}