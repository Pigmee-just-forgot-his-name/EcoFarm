// Parent directory hierarchy is QLNongSan/Database
namespace QLNongSan.Databases
{
    using Microsoft.Data.SqlClient;

    // Database factory - manages connection pooling and is responsible for creating connnection in stateless repositories/DALs
    public class SQLServerFactory
    {

        private readonly string connectionString;

        public SQLServerFactory(string serverName, string databaseName, string userName, string password)
        {
            connectionString = @"Data Source=localhost;Initial Catalog=QuanLyNongSan;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(this.connectionString);
        }
    }
}