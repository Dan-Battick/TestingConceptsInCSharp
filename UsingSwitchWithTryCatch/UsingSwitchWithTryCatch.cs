using System;

namespace UsingSwitchWithTryCatch
{
    class UsingSwitchWithTryCatch
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < 5; x++)
            {
                int choice = 0;
                try
                {
                    Console.Write("Please enter either 1 or 2 or 3 or 4: ");
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                switch (choice)
                {
                    case 1:
                    case 13:
                        Console.WriteLine("Haha you chose 1!");
                        break;
                    case 2:
                    case 24:
                        Console.WriteLine("Haha you chose 2!");
                        break;
                    case 3:
                    case 35:
                        Console.WriteLine("Haha you chose 3!");
                        break;
                    case 4:
                    case 46:
                        Console.WriteLine("Haha you chose 4!");
                        break;
                    default:
                        Console.WriteLine("Loser!");
                        break;
                }
            }
        }
    }
}
