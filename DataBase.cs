namespace Курсовая
{
    internal static class DataBase
    {
        private static readonly SqlConnection DbConnection = new SqlConnection(@"Data Source=Win10x64;Initial Catalog=InternetProvider;integrated Security= true ");

        public static void OpenConnection()
        {
            if (DbConnection.State == ConnectionState.Closed)
                DbConnection.Open();
        }

        public static void CloseConnection()
        {
            if (DbConnection.State == ConnectionState.Open)
                DbConnection.Close();
        }

        public static SqlConnection GetConnection()
        {
            return DbConnection;
        }
    }
}
