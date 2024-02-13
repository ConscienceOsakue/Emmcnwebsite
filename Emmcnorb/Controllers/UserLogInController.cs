using Emmcnorb.Models;
using Microsoft.AspNetCore.Mvc;

namespace Emmcnorb.Controllers
{
    /*The Controller handles user input, processes it, and communicates
   with the Model and View accordingly. It acts as an intermediary between
   the Model and View, receiving requests from the user, updating the Model,
   and then rendering the appropriate View with the updated data.*/

    // added the controller to the method
    public class UserLogInController : Controller
    {
        private readonly IUserLogInRepository repo;

        public UserLogInController(IUserLogInRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult UserLogIn() //the code to view the login page
        {
            return View();
        }

        public IActionResult InsertUserLogInToDatabase(UserLogIn userloginToInsert)
        {
            repo.InsertUserLogIn(userloginToInsert);
            return RedirectToAction("UserLogIn"); // this is the code that redirect my login infor to a page.
        }
        

    }
}
    

