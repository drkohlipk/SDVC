// using System.Linq;
// using Dapper;
// using System.Data;
// using MySql.Data.MySqlClient;
// using sdvcWebapp.Models;
// using Microsoft.Extensions.Options;

// namespace sdvcWebapp.Factory
// {
// 	/*****************Added as part of DB Config********************/
// 	public class UserFactory : IFactory<User> {

// 		private readonly IOptions<MySqlOptions> mysqlConfig;
		
// 		public UserFactory(IOptions<MySqlOptions> conf) {
// 				mysqlConfig = conf;
// 		}
		
// 		internal IDbConnection Connection {
// 			get {
// 				return new MySqlConnection(mysqlConfig.Value.ConnectionString);
// 			}
// 		}
// 		/*****************Added as part of DB Config********************/
		
// 		public User Add(User item)
//         {
//             using (IDbConnection dbConnection = Connection) {
//                 string query = "INSERT INTO users (first_name, last_name, email, password, created_at, updated_at) VALUES (@first_name, @last_name, @email, @password, NOW(), NOW());";
//                 dbConnection.Open();
//                 dbConnection.Execute(query, item);
//                 return dbConnection.Query<User>("SELECT * FROM users WHERE email = @Email;", new {@Email = item.email}).SingleOrDefault();
//             }
//         }
//         public User FindByEmail(string email)
//         {
//             using (IDbConnection dbConnection = Connection)
//             {
//                 dbConnection.Open();
//                 return dbConnection.Query<User>("SELECT * FROM users WHERE email = @Email;", new { Email = email }).SingleOrDefault();
//             }
//         }
// 	}
// }