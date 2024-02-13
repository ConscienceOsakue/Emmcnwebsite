using System.Collections.Generic;
namespace Emmcnorb.Models
{
    //Models are typically responsible for retrieving and storing data
    //from and to a data store, such as a database
    public class UserLogIn
    {
        // creating the user login and sign on page it requires a database and i will use MySQL 
        public int UserID { get; set; }
        public required string Username { get; set; } //I added required because they all non-nullable properties so the controller can process it.
        public required string Email { get; set; }
        public required string Password { get; set; }
        //public IEnumerable<Category> Categories { get; set; }


    }
}
