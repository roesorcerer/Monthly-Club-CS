using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Subscribers
    {
        static void Main(string[] args)
        {
            string firstName, lastName;
            List<string> names = new List<string>();
            List<int> sub = new List<int>();
            List<int> ship = new List<int>();
            List<int> month = new List<int>();
            //Welcome message 
            Console.WriteLine("Welcome to the Of the Month subscription program!");
            //promt user for first and last name and add to array. 
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();
            names.Add(firstName);
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();
            names.Add(lastName);
            while (true)
            {//while statement if true user will be prompted to chose sub options. 
                Console.WriteLine("Please select a subscription option for " + string.Join(" ", names));
                Console.WriteLine("Press 1 for Ice Cream subscription at $12 a month.");
                Console.WriteLine("Press 2 for Bacon subscription at $15 a month.");
                Console.WriteLine("Press 3 for Peanut Butter subscription at $17 a month.");
                int subscriptionType = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please choose a shipping method:");
                Console.WriteLine("Press 1 for regular shipping at $5 a month.");
                Console.WriteLine("Press 2 for expedited shipping at $10 a month.");
                Console.WriteLine("Press 3 for overnight shipping at $17 a month.");
                int shipping = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How many months would you like to have this subscription?");
                int months = Int32.Parse(Console.ReadLine());
                month.Add(months);

                int monthly = 0;
                switch (subscriptionType)
                {//swtch/case to add sub type to array so that multiple items can be added if needed. 
                    case 1:
                        Console.WriteLine("Thanks for choosing Ice Cream!");
                        monthly = 12;
                        sub.Add(monthly);
                        break;
                    case 2:
                        Console.WriteLine("Thanks for choosing Bacon!");
                        monthly = 15;
                        sub.Add(monthly);
                        break;
                    case 3:
                        Console.WriteLine("Thanks for choosing Peanut Butter!");
                        monthly = 17;
                        sub.Add(monthly);
                        break;
                }
                int shippingMonthly = 0;
                switch (shipping)
                {//swtch/case for shipping options to be added to array to hold multiple values. 
                    case 1:
                        Console.WriteLine("Thanks for choosing regular shipping!");
                        shippingMonthly = 5;
                        ship.Add(shippingMonthly);
                        break;
                    case 2:
                        Console.WriteLine("Thanks for choosing expedited shipping!");
                        shippingMonthly = 10;
                        ship.Add(shippingMonthly);
                        break;
                    case 3:
                        Console.WriteLine("Thanks for choosing overnight shipping!");
                        shippingMonthly = 30;
                        ship.Add(shippingMonthly);
                        break;
                }
                //statements to calculate totals. 
                double sum1 = sub.Sum();
                double sum2 = ship.Sum();
                double sum3 = month.Sum();

                double monthlyTotal = sum1 + sum2;
                double totalCost = monthlyTotal * sum3;
                double discount = 0;
                if (totalCost > 150)
                {//if statement that will calculate discount depending on totals. 
                    discount = totalCost * 0.10;
                }
                else if (totalCost > 100)
                {
                    discount = totalCost * 0.07;
                }
                else if (totalCost > 50)
                {
                    discount = totalCost * 0.05;
                }


                double costAfterDiscount = totalCost - discount;


                double tax = costAfterDiscount * 0.04;

                //final statements to show totals and discount. If more items are added this statement will update with totals. 
                Console.WriteLine("Total cost breakdown for " + string.Join(" ", names));
                Console.WriteLine("Total cost for subscriptions: " + totalCost);
                Console.WriteLine("Discount total: " + discount);
                Console.WriteLine("Cost after discount: " + costAfterDiscount);
                Console.WriteLine("Tax: " + tax);
                Console.WriteLine("Total cost after Tax: " + (costAfterDiscount + tax));

                //statement below will ask the user if they want to continue. If they do this will go back to the while statement. If not program ends. 
                Console.WriteLine("Do you want to add another subscription?(Y/N) ");
                String nextOption = Console.ReadLine();
                if (nextOption.Equals("Y") || nextOption.Equals("y"))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Thanks for using this program! Goodbye!");
                    break;
                }

            }
        }
    }
}
