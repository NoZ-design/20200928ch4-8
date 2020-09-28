using System;

namespace _20200928ch4_8
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("name1");
            Account account2 = new Account("name2");

            Console.WriteLine($"account1's name is:{account1.name}");
            Console.WriteLine($"account2's name is:{account2.name}");
            Console.ReadKey();
        }
    }
}
