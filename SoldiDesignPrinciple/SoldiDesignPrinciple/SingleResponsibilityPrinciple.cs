using System;


namespace SoldiDesignPrinciple
{
    //The Single-responsibility principle:--- "There should never be more than one reason for a class to change."
    //In other words, every class should have only one responsibility.


    //Robert Martin summarizes this principle well by mandating that, “a class should have one, and only one, reason to change.”
    //    Following this principle means that each class only does one thing and every class or module only has responsibility for one part of the software’s functionality.
    //    More simply, each class should solve only one problem.

    //This means that every class, or similar structure, in your code should have only one job to do. Everything in that class should be related to a single purpose.

    //The single Responsibility Principle gives us a good way of identifying classes at the design phase of an application and it makes you think of all the ways a class can change.
    //A good sepeartion of responsibilities is done onlu when we have the full picture of how application should work.

    //Let us check this with an example.
    public class UserService
    {
        public void Register(string email, string password)
        {
            Console.WriteLine("Registration of User");
        }
        public void ValidateEmail(string email)
        {
            Console.WriteLine("This Function Validate the email of user.");
        }
        public void SendEmail(string message)
        {
            Console.WriteLine("This function send email to each user.");
        }
    }

    //It looks fine, but it is not following SRP.The SendEmail and ValidateEmail methods have nothing to do within the UserService class. 
    //Let's refract it.


    public class UserService_following_SRP
    {
        public void Register(string email, string password)
        {
            Console.WriteLine("Registration of User");
        }

    }

    public class EmailService
    {
        public void ValidateEmail(string email)
        {
            Console.WriteLine("This Function Validate the email of user.");
        }

        public void SendEmail(string message)
        {
            Console.WriteLine("This function send email to each user.");
        }
    }

    // Here the email service doesnot agins contains two function.
    // one for Validating the email and another is for sending the email.
    // we can again refactor this service to implement SRP

    public class ValidateEmailService
    {
        public void ValidateEmail(string email)
        {
            Console.WriteLine("This Function Validate the email of user.");
        }

    }

    public class SendEmailService
    {
        public void SendEmail(string message)
        {
            Console.WriteLine("This function send email to each user.");
        }
    }


    // Now our finel class too perform our required oepration is

    public class SingleResponsibilityPrinciple
    {
        public static void Main()
        {
            // ## Registering a user
            UserService_following_SRP userService = new UserService_following_SRP();
            userService.Register("email", "password");

            // ## Verifying the email of that perticular user
            ValidateEmailService emailService = new ValidateEmailService();
            emailService.ValidateEmail("email");

            // ## sending the email to the user
            SendEmailService sendEmailService = new SendEmailService();
            sendEmailService.SendEmail("Message to email.");
        }      
    }
}
