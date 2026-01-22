/*Delegate vs Func/Action

Rewrite a custom delegate using:


Func<int, int, int>


Action<string>*/

using System;
class Calculationsssss
{
    public void Add(int a, int b) { Console.WriteLine(a + b); }
    public void Sub(int a, int b) { Console.WriteLine(a - b); }
    public void Mul(int a, int b) { Console.WriteLine(a * b); }
}
