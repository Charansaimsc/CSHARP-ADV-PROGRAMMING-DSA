/* Maintain a mapping of product IDs to product information.
OOP Concepts:
● Interface: Product
● Encapsulation: Inventory manager manages internal map.
● Abstraction: Simple add(), get() interface.
● Polymorphism: Products can be electronics, clothing, etc.*/
using System;

public interface IProduct
{
    int Id { get; }
    string Name { get; }
    void Display();
}
public class Electronics : IProduct
{
    public int Id { get; }
    public string Name { get; }
    private string BrandName;
    public Electronics(int Id,string Name,String BrandName)
    {
        this.Id = Id;
        this.Name = Name;
        this.BrandName = BrandName;
    }
    public void Display()
    {
        Console.WriteLine($"Electronics ----> Id {Id},NAME : {Name},Brandname : {BrandName}");
    }
}
public class Clothing : IProduct
{
    public int Id { get; }
    public string Name { get; }
    private string Size;
    public Clothing(int Id,string Name,string Size)
    {
        this.Id = Id;  
        this.Name = Name;
        this.Size = Size;

    }
    public void Displaay()
    {
        Console.WriteLine($"Clothing ----> Id{Id},Name : {Name},Size : {Size}");
    }
}
public class InventaryManager
{
    private Dictionary<int,string> Products = new Dictionary<int,string>();
    public void add(IProduct product)
    {
        Products[product.Id] = product;
    }
    public void get(IProduct product)
    {
        if(Products.ContainsKey(product.Id))
    }
}