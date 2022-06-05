//using BCrypt.Net;
//using WarehouseManagmentSystemAPI.Dtos;

///**
//    Hey Arif here just change DBContext to the name of our context and don't forget to add
//    the _UserDto.cs file to DbConext class. plus change the _UserDto.cs to a more appropriate name.
//**/


//namespace WarehouseManagmentSystemAPI.Actions
//{
//   class AuthApiAction
//   {
//      void login(string email, string password) {
//            DBContext context = new DBContext();
//            _UserDto user = context.User.Where(u => u.email == email).Single();
//            if (!user) {
//                return new {
//                    errCode = 9150,
//                    message = "[Error] Email does not exsit" 
//                };
//            }
//            var hashedPassword = user.password;
//            if (BCrypt.Net.BCrypt.Verify(password, hashedPassword))
//            {
//                return user;
//            } else {
//                return new { error = 9200, message = "[Error] Password does not match email" };
//            }
//        }

//        void register(string email, string password, string firstName, string lastName) {
//            DBContext context = new DBContext();

//            if (context.User.Any(u => u.email == email)) return new { 
//                error = 9100, 
//                message = "[Error] This email is already in use"
//            };

//            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
//            var user = new _UserDto{
//                firstName = firstName,
//                lastName = lastName,
//                email = email,
//                password = hashedPassword
//            };

//            context.User.Add(user);
//            context.SaveChanges();
//            return user;
//        }
//   }
//}