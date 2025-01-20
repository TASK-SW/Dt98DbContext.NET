using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext
{
    /// <summary>
    /// <b>Dt98UserContextFactory</b>
    /// </summary>
    public class Dt98UserContextFactory
    {
        #region Private Fields

        private readonly string _connectionString;

        private Dt98UserContextFactory _dbContextFactory;

        #endregion Private Fields

        #region Public Constructors

        public Dt98UserContextFactory(string connectionString)
        {
            //if (connectionString.ToLower().Contains("provider"))
            //{
            //    OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder(connectionString);
            //    builder.Remove("provider");
            //    connectionString = builder.ConnectionString;
            //}

            _connectionString = connectionString;
        }

        #endregion Public Constructors

        #region Public Methods

        public DT98UserEFCoreDbContext GetDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<DT98UserEFCoreDbContext>();
            optionsBuilder.UseSqlServer(_connectionString);

            return new DT98UserEFCoreDbContext(optionsBuilder.Options);

        }

        #endregion Public Methods
    }
}