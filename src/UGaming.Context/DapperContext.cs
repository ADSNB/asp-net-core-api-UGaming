using Npgsql;
using System.Data;
using UGaming.Context.Interfaces;
//using UGaming.API;

namespace UGaming.Context
{
    public class DapperContext : IDapperContext
    {
        private readonly string _connectionString;
        private IDbConnection _connection;

        public DapperContext()
        {
            _connectionString = "Server=localhost;Database=ugaming;User ID=postgres;Password=master;Encoding=UTF-8;CommandTimeout=360";
        }

        public IDbConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new NpgsqlConnection(_connectionString);
                }
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }
                return _connection;
            }
        }

        public void Dispose()
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
                _connection.Close();
        }
    }
}
