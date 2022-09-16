using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16SepEvining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Details d=new Details();
            Console.WriteLine("Enter Name");
            d.name=Console.ReadLine();
            Console.WriteLine("Enetr age");
            d.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enetr Contact");
            d.Contact=long.Parse(Console.ReadLine());
            Console.WriteLine("1.Name\r\n2.Age\r\n3.Contact");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine(d.name);
                    break;
                    case 2:
                    Console.WriteLine(d.age); break;
                    case 3:
                    Console.WriteLine(d.Contact);
                    break;
            }
            Console.ReadLine();
        }
    }
}
