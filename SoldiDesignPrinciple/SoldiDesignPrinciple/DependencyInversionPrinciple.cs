using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
namespace SoldiDesignPrinciple
{

    //The Dependency Inversion Principle(DIP) states that high-level modules/classes should not depend on low-level modules/classes.
    //Both should depend upon abstractions.Secondly, abstractions should not depend upon details.Details should depend upon abstractions.


    // Let's crate a example User as a high level class that directly depends on low level data access layer class.

    public class User
    {
        public void RegisterUser(string userName)
        {
            UserDataAccessLayer userDataAccessLayer = new UserDataAccessLayer();
            userDataAccessLayer.SaveUserToDb(userName);
        }
    }

    // craete a class for data access layer
    public class UserDataAccessLayer 
    {
        public void SaveUserToDb(string userName)
        {
            Console.WriteLine(userName, "Got saved.");
        }
    }

    // Looks fine for now. But when we change the logic for data access layer then we need to change the User class also.
    // to prevent this and build our system lossly coupled we can implement dependency iunversion principle
    // for this we define a interface and use that interface  to establish a communication bridg between high level class and low level class.

    public interface IUserRegistration
    {
        public void RegisterUser(string userName);
    }

    // extend this interface in low level class
    public class UserRegistrationDAL : IUserRegistration
    {
        public void RegisterUser(string userName)
        {
            Console.WriteLine(userName, "Got saved.");
        }
    }

    // the high level class use this interface to access our data access layer class.
    public class AddUser
    {
        IUserRegistration _userRegistration; 
        public AddUser(IUserRegistration userRegistration)
        {
            this._userRegistration = userRegistration;
        }

        // now we can access the attribtes and methods of low level class
        public void RegisterUser()
        {
            _userRegistration.RegisterUser("Khageshor Giri");
        }
       
    }
}
