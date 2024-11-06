using craveyard.Server.Repositories;
using System.Data;
using Dapper;

namespace craveyard.Server.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbConnection _db;

        public UserRepository(IDbConnection db)
        {
            _db = db;
        }

        public int RegisterUser(User user)
        {
            var sql = "INSERT INTO Users (Username, Password, Email) VALUES (@Username, @Password, @Email)";
            return _db.Execute(sql, user); // Synchronous execution
        }

        public User LoginUser(string username, string password)
        {
            var sql = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
            return _db.QueryFirstOrDefault<User>(sql, new { Username = username, Password = password }); // Synchronous execution
        }
    }
}
