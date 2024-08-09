using DemoADV04.Fifa;
using DemoADV04.Youtube;
using System.Collections;

namespace DemoADV04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region EX01
            //Ball ball = new Ball() { Id = 12 };
            //Console.WriteLine(ball);
            //ball.Location = new Location() { X = 1, Y = 1, Z = 1 };
            //Console.WriteLine(ball);


            //Player player1 = new Player() { Name = "Messi", TeamName = "Barca" };
            //Player player2 = new Player() { Name = "Pedri", TeamName = "Barca" };
            //Player player3 = new Player() { Name = "Marcelo", TeamName = "Madrid" };
            //Player player4 = new Player() { Name = "Modric", TeamName = "Madrid" };
            //Player player5 = new Player() { Name = "Kroos", TeamName = "Madrid" };


            //Refree Refree1 = new Refree() { Name = "Gehad" };
            //ball.Location = new Location() { X = 1, Y = 1, Z = 2 };


            //ball.BallLocationChanged += player1.Run;
            //ball.BallLocationChanged += player2.Run;
            //ball.BallLocationChanged += player3.Run;
            //ball.BallLocationChanged += player4.Run;
            //ball.BallLocationChanged += Refree1.Look;
            ////ball.BallLocationChanged = Refree1.Look;  //is not allowed with event key word

            ////ball.Location = new Location() { X = 1, Y = 1, Z = 2 };

            //ball.Location = new Location() { X = 2, Y = 3, Z = 2 };
            //ball.BallLocationChanged -= player4.Run;
            //ball.BallLocationChanged += player5.Run;
            //Console.WriteLine("------------------ After Sub -------------------------");

            //ball.Location = new Location() { X = 2, Y = 5, Z = 2 }; 
            #endregion

            #region EX02
            //Channel channel = new Channel() { ChannelName = "ABC"};
            //channel.AddVideo(new Video() {Title = "Title01" , Description = "Description1" });
            //subscriber subscriber1 = new subscriber() { Name = "Zalta" };
            //subscriber subscriber2 = new subscriber() { Name = "Ali" };
            //subscriber subscriber3 = new subscriber() { Name = "Mahmoud" };
            //channel.UploadVideo += subscriber1.Notify; 
            //channel.UploadVideo += subscriber2.Notify;


            //channel.AddVideo(new Video() { Title = "Title02", Description = "Description2" });

            #endregion


            #region Hashtable : Non-Generic

            //Hashtable ht = new Hashtable();
            //Console.WriteLine($"Count : {ht.Count}");

            //ht.Add("Ahemd", 899999);
            //ht.Add("Ali", 231241);
            //ht.Add("Mostafa", 34523462);

            //foreach (DictionaryEntry item in ht) 
            //{
            //    Console.WriteLine($"Key : {item.Key} , Value : {item.Value}");
            //}

            //foreach (object item in ht.Keys) 
            //{
            //    Console.WriteLine(item);
            //}




            #endregion

            #region Dictionary : Generic

            Dictionary<string , int>  Note = new Dictionary<string , int>();

            Note.Add("Mostafa", 123);
            Note.Add("Ali", 34123);
            //Note.Add("Ali", 54623546);


            foreach (KeyValuePair<string , int> note in Note) 
            {
                Console.WriteLine(note);
            }
            #endregion











        }
    }
}
