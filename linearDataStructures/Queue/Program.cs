using System;
namespace queue
{
    public class Program
    {
        public static void Main(string[] args)
             {
            //Print PS = new Print();
            //PS.Add(new XeroxPaper("777"));
            //PS.Add(new Photo("photos.jpg"));    
            //PS.Add(new Photo("555"));

            //PS.Next();
            //PS.Next();
            //PS.Next();
            //PS.Next();



            //BookingService Bs = new BookingService();
            //Bs.Add(new flight("charan"));
            //Bs.Add(new train("sai"));
            //Bs.Add(new train("saicharan"));
            //Bs.Next();
            //Bs.Next();


            //PriorityTask PT = new PriorityTask();
            //PT.Add(new Upload("sai charan muchakarla"));
            //PT.Add(new Report("Muchakarla sai charan "));
            //PT.Add(new Report("sai charan msc"));
            //PT.Add(new Report("alphabets"));
            //PT.Next();
            //PT.Next();



            
                CallCenterManager manager = new CallCenterManager();

                manager.AddCall(new SupportCall("SAI"));
                manager.AddCall(new SalesCall("Charan"));
                manager.AddCall(new SupportCall("Muchakarla"));

                manager.HandleNextCall();
                manager.HandleNextCall();
                manager.HandleNextCall();
                manager.HandleNextCall();
            
        }
    }
}