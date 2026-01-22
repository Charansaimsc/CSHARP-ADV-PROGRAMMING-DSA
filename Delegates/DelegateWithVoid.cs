
/*Delegate with void Return Type

Define a delegate that prints a message.

Pass different methods to display:


Welcome message


Error message


Success message

*/



using System;
delegate void Message(string message);
class Messages
{
    public void Welcome(string message)
    {
        Console.WriteLine("welcome message");
    }
    public void Error(string message) { Console.WriteLine("errorrrrrrrr"); }
    public void Success(string message) { Console.WriteLine("successssssssss"); }
}