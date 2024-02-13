using Emmcnorb.Models;

namespace Emmcnorb
{
    // Interface tha i used to define a set of methods / properties that my UserLogIn class will implement.
    public interface IUserLogInRepository
    {
        public void InsertUserLogIn(UserLogIn userloginToInsert);
        public void GetUserLogIn(int id);
        public void UpdateUserLogIn(UserLogIn userlogin);
        
    }
}
