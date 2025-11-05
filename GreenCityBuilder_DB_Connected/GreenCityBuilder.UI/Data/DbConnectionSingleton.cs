using System;
using System.Configuration;
using System.Data.SqlClient;

namespace GreenCityBuilder.UI.Data
{
    public sealed class DbConnectionSingleton
    {
        private static readonly Lazy<DbConnectionSingleton> _instance =
            new Lazy<DbConnectionSingleton>(() => new DbConnectionSingleton());

        private readonly string _connectionString;

        private DbConnectionSingleton()
        {
            _connectionString = "Data Source=MATTO;Initial Catalog=GreenCityDB;Integrated Security=True;Encrypt=False;"; 
        }

        public static DbConnectionSingleton Instance => _instance.Value;

        public SqlConnection Create()
        {
            var conn = new SqlConnection(_connectionString);
            conn.Open();
            return conn;
        }
    }
}
