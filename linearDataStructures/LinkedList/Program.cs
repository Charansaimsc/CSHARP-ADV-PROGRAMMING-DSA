using System;
namespace lINKEDlIST
{
    public class Program
    {
        static void Main(string[] args)
        {
            //NavigationHistory History = new BrowserHistory();
            //History.Visit("land8form.com");
            //History.Visit("BinaryBridge.com");
            //History.Visit("Gla.ac.in");
            //History.Visit("instagram.com");
            //Console.WriteLine(History.Back());
            //Console.WriteLine(History.Back());
            //Console.WriteLine(History.Forward());
            //Console.WriteLine(History.Current());


            MediaPlayer player = new MusicPlayer();

            player.AddMedia("Believer", "Imagine Dragons");
            player.AddMedia("Numb", "Linkin Park");
            player.AddMedia("Shape of You", "Ed Sheeran");

            player.PlayNext();
            player.PlayNext();
            player.PlayNext();
            player.PlayNext();

            Console.ReadLine();
        }
    }
}