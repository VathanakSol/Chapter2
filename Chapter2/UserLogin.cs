using System;
namespace Chapter2;

class UserLogin
{
    static void Mainx(String[] args)
    {
        Console.Clear();
        string name, pass;
        
        Console.Write("Enter username: ");
        name = Console.ReadLine();
        Console.Write("Enter password: ");
        pass = Console.ReadLine();
        if (name == "Vathanak")
        {
            if (pass == "abc123")
            {
                Console.WriteLine("Verified your own account");
                int a, b, result;
                Console.Write("Input A: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Input B: ");
                b = int.Parse(Console.ReadLine());
                result = a + b;
                Console.Write("The result: " + result);
            }
            else
            {
                Console.Write("Invalid account!");
            }
        }
        else
        {
            Console.Write("Invalid account");
        }
        Console.ReadKey();
    }


        
}

