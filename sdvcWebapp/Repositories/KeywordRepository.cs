// using System;
// using System.Collections.Generic;
// using sdvcWebapp.Models;
// using Dapper;
// using System.Linq;
// using MySql.Data;

// namespace sdvcWebapp.Repository
// {
//     public class KeywordRepository : IKeywordRepository
// {
//     private readonly Microsoft.Extensions.Options.IOptions<MySqlOptions> _dbOptions;
//     public KeywordRepository(Microsoft.Extensions.Options.IOptions<MySqlOptions> mySqlOptions)
//     {
//         _dbOptions = mySqlOptions;
//     }
//     private System.Data.IDbConnection _db;

//     public IEnumerable<Keyword> GetAll()
//     {
//         using(_db = new MySqlConnection(_dbOptions.Value.ConnectionString))
//         {
//             return _db.Query<Keyword>("SELECT * FROM \"Keywords\";");
//         }
//     }

//     public Keyword FindById(int id)
//     {
//         using(_db = new MySqlConnection(_dbOptions.Value.ConnectionString))
//         {
//         return _db.QuerySingleOrDefault("SELECT * FROM \"Keywords\" WHERE id = @id;", new {id});
//         }
//     }
// //TODO: Fix This
//     public int Add(Keyword keyword)
//     {
//         int responseId = -1;
//         if(keyword.kw.Length <= 100)
//         {
//             try
//             {
//                 using(_db = new MySqlConnection(_dbOptions.Value.ConnectionString))
//                 {
//                     string rightNow = DateTime.UtcNow.ToString();
//                     //TODO: Complete
//                     string query = String.Format("INSERT INTO keywords (kw,created_at,updated_at) VALUES (@kw,{0},@rightNow); SELECT CAST(SCOPE_IDENTITY() as int)",rightNow);
//                 //Returns the new item's ID
//                 responseId = _db.Query<int>(query,keyword).SingleOrDefault();
//                 }
//             }catch(Exception ex)
//             {
//                 return -2;
//             }
//         }
//         return responseId;
//     }

//     public Keyword FindByText()
//     {
//         throw new NotImplementedException();
//     }

//     List<Keyword> IBaseRepository<Keyword>.GetAll()
//     {
//         throw new NotImplementedException();
//     }

//     Keyword IBaseRepository<Keyword>.FindById(int id)
//     {
//         throw new NotImplementedException();
//     }

//     public Keyword Update(Keyword entity)
//     {
//         throw new NotImplementedException();
//     }

//     public void RemoveById(int id)
//     {
//         throw new NotImplementedException();
//     }
// }
// }