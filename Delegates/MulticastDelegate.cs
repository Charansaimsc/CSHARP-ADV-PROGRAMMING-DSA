//Multicast Delegate

//Create a delegate that returns void.

//Attach multiple methods and observe the execution order.


using System;

class Calculationss
{
    public int Add(int a, int b) { return (a + b); }
    public int Sub(int a, int b) { return (a - b); }
    public int Mul(int a, int b) { return (a * b); }
}