using System;
using System.Linq;

namespace GirlScoutCookies
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterOrder ordering = new MasterOrder();

            ordering.AddOrder(new CookieOrder("mint", 5));
            ordering.AddOrder(new CookieOrder("chocolate", 5));
            ordering.AddOrder(new CookieOrder("raisin", 5));
            ordering.AddOrder(new CookieOrder("mint", 5));

            ordering.ShowOrder();
            bool runmenu = true;
            do
            {
                Console.WriteLine("1.Show order\n2.Total boxes ordered\n3.Remove variety\n4.Total boxes of variety");
                string input = Console.ReadLine();
                string nameofvariety;
                switch (input)
                { 
                    case "1":
                        Console.Clear();
                        ordering.ShowOrder();
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("You are ordering {0} boxes", ordering.GetTotalBoxes());
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Enter variety you wish to remove");
                        nameofvariety = Console.ReadLine();
                        ordering.RemoveVariety(nameofvariety.ToLower());
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Enter variety" );
                        nameofvariety = Console.ReadLine();
                        ordering.GetVarietyBoxes(nameofvariety);
                        Console.WriteLine("Total amount of this variety is : {0} ", ordering.GetVarietyBoxes(nameofvariety));
                        Console.ReadKey();
                        break;
                    
                }
            } while (runmenu);
        }
    }
}
