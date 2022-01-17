using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание17
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введите номер счета");
                Account<int> account1 = new Account<int>();
                account1.Number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите баланс");
                account1.Balance = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите ФИО владельца");
                account1.Name = Console.ReadLine();
                print(account1.Number);
                print(account1.Balance);
                print(account1.Name);
            Console.WriteLine("Введите номер счета");
            Account<double> account2 = new Account<double>();
            account2.Number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите баланс");
            account2.Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО владельца");
            account2.Name = Console.ReadLine();
            print(account2.Number);
            print(account2.Balance);
            print(account2.Name);
            Console.WriteLine("Введите номер счета");
            Account<string> account3 = new Account<string>();
            account3.Number = Console.ReadLine();
            Console.WriteLine("Введите баланс");
            account3.Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО владельца");
            account3.Name = Console.ReadLine();
            print(account3.Number);
            print(account3.Balance);
            print(account3.Name);
            Console.ReadKey();

        }
        class Account<T>
        {
            public T Number { get; set; }
            public double Balance { get; set; }
            public string Name { get; set; }
        }
        static void print <T>(T X)
        {
            Console.WriteLine(X);
        }
    }
}
