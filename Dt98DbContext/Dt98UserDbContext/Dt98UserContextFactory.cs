using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (connectionString.ToLower().Contains("provider"))
            {
                OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder(connectionString);
                builder.Remove("provider");
                connectionString = builder.ConnectionString;
            }

            _connectionString = connectionString;
        }

        #endregion Public Constructors

        #region Public Methods

        public Dt98UserEf6DbContext GetDbContext()
        {
            return new Dt98UserEf6DbContext(_connectionString);
        }

        #endregion Public Methods
    }
}