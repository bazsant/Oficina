using Microsoft.Extensions.Configuration;
using Oficina.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using Oficina.Models;

namespace Oficina.Repository
{
    public class DapperRepository: IDapperRepository
    {
        private readonly IConfiguration _configuration;

        public DapperRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        public int Execute(string sql, object param)
        {
            using (SqlConnection conexao = new SqlConnection(
               _configuration.GetConnectionString("SqlServerConnection")))
            {
                return conexao.Execute(sql, param);
            }
        }

        public IEnumerable<T> Query<T>(string sql)
        {
            using (SqlConnection conexao = new SqlConnection(
               _configuration.GetConnectionString("SqlServerConnection")))
            {
                return conexao.Query<T>(sql);
            }
        }

        public IEnumerable<T> Query<T>(string sql, object param)
        {
            using (SqlConnection conexao = new SqlConnection(
               _configuration.GetConnectionString("SqlServerConnection")))
            {
                return conexao.Query<T>(sql, param);
            }
        }

    }
}
