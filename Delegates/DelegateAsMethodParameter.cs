using System;
delegate int Operation(int a,int b);
class Calculator
{
    public int Add(int a,int b) {  return a + b; }
    public int Sub(int a,int b) {return a - b;}
    public int Mul(int a, int b) { return a * b; }
}
class MathP
{
    public int PerformOperation(int a,int b,Operation Op)
    {
        return Op(a,b); 
    }
}