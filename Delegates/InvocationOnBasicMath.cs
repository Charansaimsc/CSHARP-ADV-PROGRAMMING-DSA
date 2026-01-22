/*Simple Delegate Invocation

Create a delegate that takes two integers and returns an integer.

Implement methods for Add, Subtract, Multiply, and invoke them using the delegate.*/


using System;
delegate int Math(int A,int B);
class Calculation
{
    public static int  Add(int A, int B)
    {
        return A + B;
    }
    public static int Subtract(int A, int B) { return A - B; }
    public static int Multiply(int A, int B) { return (A * B); }
    public static int division(int A, int B) { return (A / B); }

}