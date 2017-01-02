using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using sdvcWebapp.Models;
using System.Collections.Generic;

namespace sdvcWebapp.Repository
{
    // public class KeywordRepository : IKeywordRepository
    // {
    //     private IDbConnection _db;

    //     public IEnumerable<Keyword> GetAll()
    //     {
    //         using(_db = new MySqlConnection(mysqlConfig.Value.ConnectionString))
    //         {
    //             return _db.Query<Keyword>("SELECT * FROM \"Keywords\";");
    //         }
    //     }
    // }
}