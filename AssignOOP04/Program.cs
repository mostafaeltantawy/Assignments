using AssignOOP04.Q1;
using AssignOOP04.Q2.Interfaces;
using AssignOOP04.Q2;
using AssignOOP04.Q3.Interfaces;
using AssignOOP04.Q3;

namespace AssignOOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Choose
            // 1 => b) To define a blueprint for a class
            // 2 => a) private
            // 3 => b) No
            // 4 => b) Yes, interfaces can inherit from multiple interfaces
            // 5 => d) implements
            // 6 => a) Yes
            // 7 => b) No, all members are implicitly public
            // 8 => b) To provide a clear separation between interface and class members
            // 9 => b) No, interfaces cannot have constructors
            // 10 => c) By separating interface names with commas

            #endregion

            #region Q1
            //Circle c1 = new Circle(12);
            //c1.DisplayShapeInfo();

            //Rectangle rectangle = new Rectangle() { Width = 100, Height = 200 };
            //rectangle.DisplayShapeInfo();

            #endregion

            #region Q2

            //IAuthenticationService authService = new BasicAuthenticationService();
            //string name = "Mostafa";

            //if (authService.AuthenticateUser(name, "123456"))
            //{
            //    Console.WriteLine("Authenticated");
            //    Console.WriteLine(authService.AuthorizeUser(name, Role.Admin) ? "Authorized" : "Not authorized");

            //}
            //else
            //{
            //    Console.WriteLine("Not Authinticated");
            //}

            #endregion

            #region Q3 
            string recipient = "Mostafa";
            string message = "Test notifications";

            INotificationService EmailNotification = new EmailNotificationService();
            INotificationService PushNotification = new PushNotificationService();
            INotificationService SmsNotification= new SmsNotificationService();

            EmailNotification.SendNotification(recipient, message);
            PushNotification.SendNotification(recipient , message);
            SmsNotification.SendNotification(recipient, message);



            #endregion

        }
    }
}
