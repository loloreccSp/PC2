
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Homework
{
    public class Program
    {

        
        public static void Main() 
        {
            Console.OutputEncoding = Encoding.UTF8;

            int hryven = 0;
            int penny = 0;
            int cost_hrn = 0;
            int cost_penny = 0;
            int exit = 1;
            
            while (exit > 0) 
            {
                try
                {
                    Console.WriteLine("\nEnter 1 for replenishment your balance, enter 2 to show you balance, enter 3 to buy product, enter 0 for exit");
                    int menu_read = Convert.ToInt32(Console.ReadLine());

                    if (menu_read == 1)
                    {
                        Console.WriteLine("Enter hryven: ");
                        int add_hrn = Convert.ToInt32(Console.ReadLine());
                        hryven += add_hrn;
                        Console.WriteLine("Enter pennies: ");
                        int add_penny = Convert.ToInt32(Console.ReadLine());
                        penny += add_penny;

                    }

                    int all_hrn = hryven;
                    int all_penny = penny;

                    if (menu_read == 3)
                    {
                        Console.WriteLine("Enter name product: ");
                        string? name_product = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter the price in hryvnia for the product: ");
                        int price_hrn = Convert.ToInt32(Console.ReadLine());
                        cost_hrn += price_hrn;
                        Console.WriteLine("Enter the price in pennies for the item");
                        int price_penny = Convert.ToInt32(Console.ReadLine());
                        cost_penny += price_penny;

                        Product new_balance = new Product(all_hrn, all_penny, name_product, cost_hrn, cost_penny);
                        new_balance.Merchandise();
                    }

                    int ostatok_hrn = all_hrn - cost_hrn;
                    int ostatok_penny = all_penny - cost_penny;

                    if (menu_read == 2)
                    {
                        
                        Money all = new Money(ostatok_hrn, ostatok_penny);
                        all.SnowAll();
                    }
                    else if (menu_read == 0)
                    {
                        break;
                    }
                    else if (menu_read != 1 && menu_read != 3)
                    {
                        throw new Exception("Inccorect number!");
                    }



                    menu_read++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only number!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


            
        }
    }
}
