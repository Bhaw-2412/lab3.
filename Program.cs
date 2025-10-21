using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{

    class Employee {
        String name;
        
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (value.Length > 5)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("ERROR!");
                }
            }
        }
    }

    class Bank
    {
        int balance;

        public int Balance
        {
            get { return balance; }

           /*private* =>throw error*/  set  
            {
                balance = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee e = new Employee();
            //e.Name = "Bhawana";
            //Console.WriteLine(e.Name);

            Bank b = new Bank();
            b.Balance =120000;
            Console.WriteLine(b.Balance);
        }
    }
}
