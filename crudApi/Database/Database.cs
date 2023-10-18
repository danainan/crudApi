using MySqlConnector;

namespace crudApi.database
{
    public class Database : IDisposable
    {
        public MySqlConnection Connection { get; private set; }

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
