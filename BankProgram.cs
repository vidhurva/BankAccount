
using System;

namespace FirstDemo
{
    class Program
    {
        enum AccountType { Checking, Savings, Transactional, MoneyMarket};
        class client
        {
            public string name;
            public int number;
            public double savings;
        }

        // Derived class
        class info : client
        {
            public AccountType type;

            public info(string _name, int _number, double _savings, AccountType _type)
            {
                name = _name;
                number = _number;
                savings = _savings;
                type = _type;
            }

            public void Print()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Account Type: " + type);
                Console.WriteLine("Account Number: " + number);
                Console.WriteLine("Savings: " + savings + "\n");
            }
        }

        public static void Main(string[] args)
        {
            info client_one = new info("Dhruv Sharma", 301, 4000, AccountType.Savings);
            info client_two = new info("Ram Vashisht", 302, 5607, AccountType.Checking);
            info client_three = new info("Roshni Desai", 303, 2780, AccountType.Transactional);
            info client_four = new info("Rani Bhardwaj", 304, 3178, AccountType.MoneyMarket);
            client_one.Print();
            client_two.Print();
            client_three.Print();
            client_four.Print();
            Console.ReadKey();
        }
    }
} 
