namespace Test.src.Solid.S
{
    public class UserService
    {
       public void Register(User user)
        {
            // Register user logic

            // Send Email
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail(user.Email, "Welcome to our Platform");
        }
    }
}
    

    