using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12Assign
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "                                                                                                 =======\n" +
                    "BBBBBBB  000000  BBBBBBB  SSSSSS    BBBBBBB  U   U  RRRRRRR  GGGGGG  EEEEEE  RRRRRRR  SSSSSS   /:::::::::\\\n" +
                    "BB    B  00  00  BB    B  S         BB    B  U   U  RR    R  GG      EE      RR    R  S        ===========\n" +
                    "BBBBBBB  00  00  BBBBBBB   SSSS     BBBBBBB  U   U  RR   RR  GG GGG  EEEE    RR   RR   SSSSS  {{{{{{}}}}}}}\n" +
                    "BB    B  00  00  BB    B       S    BB    B  U   U  RRRRR    GG   G  EE      RRRRR         S   ===========\n" +
                    "BBBBBBB  000000  BBBBBBB  SSSSSS    BBBBBBB  UUUUU  RR   RR  GGGGGG  EEEEEE  RR   RR  SSSSSS   \\:::::::::/\n" +
                    "                                                                                                 =======\n";
            int exit = 1, c = 0, d = 0;
            double total = 0.0;
            string botd = "Burger Of The Day: Home for the Challah-Days Burger(served on a challah bread bun)", input;
            Dictionary<string, double> menu = new Dictionary<string, double>()
            {
                {"Burger of the day", 7.99 },
                {"Cheeseburger", 6.99 },
                {"Hamburger",5.99 },
                {"French Fries",2.99 },
                {"Ice Cream",1.99 }
            };

            List<string> order = new List<string>();
            List<string> custom = new List<string>();


            do
            {
                if (exit == 1)
                {
                    Console.Clear();
                    Console.WriteLine($"{title}\n{botd}\n\n");
                    foreach (string menuitem in menu.Keys)
                    {
                        Console.WriteLine("{0:C}-->{1}", menuitem, menu[menuitem]);

                    }
                    for (int i = order.Count; i == order.Count; ++i)
                        Console.Write($"\nEnter Order Item Number {i + 1}(not case sensitive)---> ");
                    input = Console.ReadLine();
                    input = Char.ToUpper(input[0]) + input.Substring(1);
                    order.Add(input);
                    Console.Clear();
                    Console.WriteLine(title);
                    Console.WriteLine("Please Enter All Toppings You Would Like On Your Burger or Fries or Flavor Of Ice Cream (ex: Lettuce,Tomato,Pickles)");
                    custom.Add(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine(title);
                    Console.Write("\nWould You Like To Order More Food?\nEnter 1 For Yes----Enter 2 For No---> ");
                    exit = Convert.ToInt32(Console.ReadLine());


                }

            } while (exit != 2);
            Console.Clear();
            Console.WriteLine(title);
            do
            {
                foreach (string orderitems in order)
                {
                    if (menu.ContainsKey(orderitems))
                    {
                        c++;
                        Console.WriteLine($"Order Item {c}--> {orderitems}");
                        total += menu[orderitems];
                    }
                    else
                        Console.WriteLine("You ordered an item that is not on the menu.");
                }
                foreach (string customs in custom)
                {
                    d++;
                    Console.WriteLine($"Customizations For Order Item {d}---> {customs}");
                }

            } while (exit != 2);
            double tax = (total * .051), realtotal = (total + tax);
            Console.WriteLine($"\nOrder SubTotal = {total:C}\nOrder Tax = {tax:C}\nOrder Total = {realtotal:C}");


        }
    }
}
