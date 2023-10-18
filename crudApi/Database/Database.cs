using MySqlConnector;

namespace crudApi.database
{
    public class Database : IDisposable
    {
        public MySqlConnection Connection { get;}

        public Database(string connectionString)
        {
            Connection = new MySqlConnection(connectionString);
        }

        public void Dispose()
        {
            Connection.Close();
        }
    }
}
