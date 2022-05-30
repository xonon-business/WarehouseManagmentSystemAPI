//using Dapper;
//using MySql.Data.MySqlClient;
//using BCrypt.Net;
//using WarehouseManagmentSystemAPI.Models;


//AuthApiAction auth = new AuthApiAction();

//namespace WarehouseManagmentSystemAPI.Actions
//{
//    class AuthApiAction
//    {
//        public void login(string email, string password)
//        {
//            string ConnectionString = "Server=lru0fksl5pbm.us-east-3.psdb.cloud;Database=wms-app;user=d459ozkgvaqj;password=pscale_pw_-zkysvQC_ouYuVsqPyjV_8S8zWOE0WLw12BuK_4NYUQ;SslMode=VerifyFull;";
//            var db = new MySqlConnection(ConnectionString);
//            var user = db.Query<User>($"SELECT * FROM User WHERE email=\"{email}\"");
//            // gets hashed password
//            string HashedPassword = string.Join(Environment.NewLine, user.Select(e => $"{e.password}"));
//            // gets user id 
//            // string UserId = string.Join(Environment.NewLine, user.Select(e => $"{e.id}"));
//            if (BCrypt.Net.BCrypt.Verify(password, HashedPassword))
//            {
//                Console.WriteLine(HashedPassword);
//            }
//        }


//        public void register(string email, string password, string firstName, string lastName)
//        {
//            string ConnectionString = "Server=lru0fksl5pbm.us-east-3.psdb.cloud;Database=wms-app;user=d459ozkgvaqj;password=pscale_pw_-zkysvQC_ouYuVsqPyjV_8S8zWOE0WLw12BuK_4NYUQ;SslMode=VerifyFull;";
//            var db = new MySqlConnection(ConnectionString);
//            var HashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
//            var sql = $"INSERT INTO User (id, email, password, firstName, lastName) VALUES(\"{Guid.NewGuid()}\", \"{email.ToString()}\",\"{HashedPassword}\", \"{firstName}\", \"{lastName}\")";
//            db.Query<User>(sql);
//        }
//    }
//}