using Microsoft.Data.SqlClient;
using System.Data;

namespace ManagementUtility
{
    public class DBContext:IDbContext
    {
        private readonly string _connectionString;

        public DBContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
