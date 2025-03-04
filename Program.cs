using System;
using System.Collections.Generic;
using POO_CSharp_P23.Entities;

namespace POO_CSharp_P23
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Como as coleções Hash testam igualdade?");
            Console.WriteLine();
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));
            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));
            Product prod = new Product("Notebook", 1200.0);
            Console.WriteLine(a.Contains(prod));
            Point point = new Point(5, 10);
            Console.WriteLine(b.Contains(point));
        }
    }
}