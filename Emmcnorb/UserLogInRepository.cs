using Dapper;
using Org.BouncyCastle.Crypto.Prng.Drbg;
using System.Collections.Generic;
using System.Data;
using Emmcnorb.Models;

namespace Emmcnorb
{
    //I created Repository for Separation of Concerns, Testability and Code Reusability.
    public class UserLogInRepository : IUserLogInRepository
    {

        private readonly IDbConnection _conn;

        public UserLogInRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        //inserting the user login information into my SQl database.
        public void InsertUserLogIn(UserLogIn userloginToInsert)
        {
            _conn.Execute("INSERT INTO userlogins (USERNAME, EMAIL, PASSWORD) VALUES (@username, @email, @password);",
                new { username = userloginToInsert.Username, email = userloginToInsert.Email, password= userloginToInsert.Password });
        }

        public UserLogIn GetUserLogIn(int id)
        {
            return _conn.QuerySingle<UserLogIn>("SELECT PersonID FROM userlogins WHERE UserID = @id", new { UserId = id });
        }

        public void UpdateUserLogIn(UserLogIn userlogin)
        {
            _conn.Execute("UPDATE userlogins SET Firstname = @firstname, Email = @emails WHERE Password = @password",
             new { username = userlogin.Username, email = userlogin.Email, password = userlogin.Password });
        }

        void IUserLogInRepository.GetUserLogIn(int id)
        {
            throw new NotImplementedException();
        }
    }
}

