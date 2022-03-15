using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack s = new MyStack();
            s.Push(1);
            Console.WriteLine($"Capacitatea stivei este: {s.Capacity} ");
            Console.WriteLine($"Numarul de elemente din stiva este: {s.Count}");
        }
    }
}
