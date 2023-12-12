using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

internal class Program
{ //receipt system
    private static void Main(string[] args)
    {
     
        design();// This method is for the design of the System
        category ct = new category(); // all functions for receipt system are here in the object
        ct.classif(); 
            for (int i = 1; 1 < 2; i--)// This function tells if the seller wants a new receipt or not
            {
                string ans;
                Console.WriteLine("\nDo You Want A New Receipt?");
                Console.Write("Choose Y/N: ");// seller will choose Y/N if he/she wants another receipt
                ans = Console.ReadLine();
                if (ans.Equals("Y", StringComparison.OrdinalIgnoreCase)) 
                {
                    design();
                    ct.classif();
                }
                else if (ans.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("THANK YOU FOR USING THIS RECEIPT SYSTEM");
                    break;
                }
                else
                {
                    Console.WriteLine("PLS TYPE Y/N");
                }
            }
        Console.ReadKey();
    }
   public static void design() {// design for the system
        Console.WriteLine("--------------------- Minerva's Sari-sari Store ----------------------");
        Console.WriteLine("========================== RECEIPT SYSTEM ============================");
    }
}
class category {

    public void classif()
    {
        List<string> cate = new List<string> { "Nova", "Mangjuan", "Piattos", "Rebisco", "Oreo", "Coke", "Royal", "Sprite", "Pepsi",
        "Sting", "Hotdog", "Tocino", "Ham", "Bacon", "Embutido", "Rexona", "Bioderm", "Colgate", "Silka", "Charmee",
        "Spam", "Flour", "Egg", "Nestea", "Milo"}; // We use Object Initialization in the list
        List<int> price = new List<int> {10, 11, 10, 10, 14, 
                                         13, 12, 14, 12, 15, 
                                         25, 40, 50, 90, 45,
                                         35, 25, 40, 60, 65, 
                                         60, 50, 12, 20, 25 };// list for price
    
        List<string> order = new List<string>();// we use 3 list to get the order, price of the item,and quantity of the customer that he/she buy
        List<double> order_price = new List<double>();
        List<double> quanty = new List<double>();
     
        double total = 0;// total price of the customer bought
        int qt; //this int is for telling the seller of how many the customer bought in the specific item
        int x;// this int 
        int count1 = 1;// Product ID
        Console.WriteLine("Product ID".PadRight(10) + "Category".PadLeft(15) + "Product".PadLeft(21) + "Price".PadLeft(22));
        Console.WriteLine("======================================================================");
        for (int i = 0; i < 5; i++)// for loop 5 times for each category
        {
            Console.WriteLine(count1 + "    ----------   "+ "Snacks"+ "    ----------  " + cate[i].PadRight(9) + "   ----------  "+ "P" + price[i]);
            count1++;
        }
        for (int i = 5; i < 9; i++)
        {
            Console.WriteLine(count1 + "    ----------   "+ "Drinks" + "    ----------  " + cate[i].PadRight(9) + "   ----------  " + "P" + price[i]);
            count1++;
        }
        Console.WriteLine(count1 + "   ----------   " + "Drinks" + "    ----------  " + cate[9].PadRight(9) + "   ----------  " + "P" + price[9]);
        count1++;
        for (int i = 10; i < 15; i++)
        {
            Console.WriteLine(count1 + "   ----------   "+"FR_Foods"+ "  ----------  " + cate[i].PadRight(9) + "   ----------  " + "P" + price[i]);
            count1++;
        }
        for (int i = 15; i < 20; i++)
        {
            Console.WriteLine(count1 + "   ----------   "+ "PR_Care" + "   ----------  " + cate[i].PadRight(9) + "   ----------  " + "P" + price[i]);
            count1++;
        }
        for (int i = 20; i < 25; i++)
        {
            Console.WriteLine(count1 + "   ----------   "+ "Grocery_I"+ " ----------  " + cate[i].PadRight(9) + "   ----------  " + "P" + price[i]);
            count1++;
        }
        Console.WriteLine("=======================================================================");
        Console.WriteLine("Type 0 if you are done");
        Console.WriteLine("DON'T MAKE THE INPUT NULL OR ELSE THE SYSTEM WILL RESET");
        Console.WriteLine("Type the Id that is given in each Item");
        Console.WriteLine("=======================================================================");
        try // try catch exception to see if in the inside of try will have a error and when there is a error, the catch will display a message/function 
        {
            for (int i = 1; 1 < 2; i--)
            { // loop
                Console.Write("Product ID: ");
                x = Convert.ToInt32(Console.ReadLine()); // this x will input the Product id of the item
                if (x == 0)
                {
                    Console.WriteLine("=======================================================");
                    break;
                    // the loop will break if the seller input the x to 0
                }
                else if (x == 1)
                {
                    order.Add(cate[0]);// the cate list will be added to order list
                    Console.Write("Enter Quantity: ");
                    qt = Convert.ToInt32(Console.ReadLine()); // quantity of the item that the customer buy
                    order_price.Add(price[0]);// the price list will be added to order_price list               
                    price[0] *= qt; // multiply the price of how many the customer buy
                    total += price[0]; // The price will be added to total
                    quanty.Add(qt);//the qt will be added to quanty list
                    Console.WriteLine("-----------ENTER A NEW PRODUCT ID OR TYPE 0 IF DONE-------------");
                    
                    price[0] = 10;// the price will go back to 10 
                }
                else if (x == 2)
                {
                    order.Add(cate[1]);
                    Console.Write("Enter Quantity: ");
                    qt = Convert.ToInt32(Console.ReadLine());
                    order_price.Add(price[1]);
                    price[1] *= qt;
                    total += price[1];
                    quanty.Add(qt);
                    Console.WriteLine("-----------ENTER A NEW PRODUCT ID OR TYPE 0 IF DONE-------------");
                    price[1] = 11;
                }
                else if (x == 3)
                {
                    order.Add(cate[2]);
                    Console.Write("Enter Quantity: ");
                    qt = Convert.ToInt32(Console.ReadLine());
                    order_price.Add(price[2]);
                    price[2] *= qt;
                    total += price[2];
                    quanty.Add(qt);
                    Console.WriteLine("-----------ENTER A NEW PRODUCT ID OR TYPE 0 IF DONE-------------");
                    price[2] = 10;
                }
                else if (x == 4)
                {
                    order.Add(cate[3]);
                    Console.Write("Enter Quantity: ");
                    qt = Convert.ToInt32(Console.ReadLine());
                    order_price.Add(price[3]);
                    price[3] *= qt;
                    total += price[3];
                    quanty.Add(qt);
                    Console.WriteLine("-----------ENTER A NEW PRODUCT ID OR TYPE 0 IF DONE-------------");
                    price[3] = 10;
                }
                else if (x == 5)
                {
                    order.Add(cate[4]);
                    Console.Write("Enter Quantity: ");
                    qt = Convert.ToInt32(Console.ReadLine());
                    order_price.Add(price[4]);
                    price[4] *= qt;
                    total += price[4];
                    quanty.Add(qt);
                    Console.WriteLine("-----------ENTER A NEW PRODUCT ID OR TYPE 0 IF DONE-------------");
                    price[4] = 14;
                }
                else if (x == 6)
                {
                    order.Add(cate[5]);
                    Console.Write("Enter Quantity: ");
                    qt = Convert.ToInt32(Console.ReadLine());
                    order_price.Add(price[5]);
                    price[5] *= qt;
                    total += price[5];
                    quanty.Add(qt);
                    Console.WriteLine("-----------ENTER A NEW PRODUCT ID OR TYPE 0 IF DONE-------------");
                    price[5] = 13;
                }
                else if (x == 7)
                {
                    order.Add(cate[6]);
                    Console.Write("Enter Quantity: ");
                    qt = Convert.ToInt32(Console.ReadLine());
                    order_price.Add(price[6]);
                    price[6] *= qt;
                    total += price[6];
                    quanty.Add(qt);
                    Console.WriteLine("-----------ENTER A NEW PRODUCT ID OR TYPE 0 IF DONE-------------");
                    price[6] = 12;
                }
                else if (x == 8)
                {
                    order.Add(cate[7]);
                    Console.Write("Enter Quantity: ");
                    qt = Convert.ToInt32(Console.ReadLine());
                    order_price.Add(price[7]);
                    price[7] *= qt;
                    total += price[7];
                    quanty.Add(qt);
                    Console.WriteLine("-----------ENTER A NEW PRODUCT ID OR TYPE 0 IF DONE-------------");
                    price[7] = 14;
                }
                else if (x == 9)
                {
                    order.Add(cate[8]);
                    Console.Write("Enter Quantity: ");
                    qt = Convert.ToInt32(Console.ReadLine());
                    order_price.Add(price[8]);
                    price[8] *= qt;
                    total += price[8];
                    quanty.Add(qt);
                    Console.WriteLine("-----------ENTER A NEW PRODUCT ID OR TYPE 0 IF DONE-------------");
                    price[8] = 12;
                }
                else if (x == 10)
                {
                    order.Add(cate[9]);
                    Console.Write("Enter Quantity: ");
                    qt = Convert.ToInt32(Console.ReadLine());
                    order_price.Add(price[9]);
                    price[9] *= qt;
                    total += price[9];
                    quanty.Add(qt);
                    Console.WriteLine("-----------ENTER A NEW PRODUCT ID OR TYPE 0 IF DONE-------------");
                    price[9] = 15;
                }
                else if (x == 11)
                {
                    order.Add(cate[10]);
                    Console.Write("Enter Quantity: ");
                    qt = Convert.ToInt32(Console.ReadLine());
                    order_price.Add(price[10]);
                    price[10] *= qt;
                    total += price[10];
                    quanty.Add(qt);
                    Console.WriteLine("-----------ENTER A NEW PRODUCT ID OR TYPE 0 IF DONE-------------");
                    price[10] = 25;
                }
                else if (x == 12)
                {
                    order.Add(cate[11]);
                    Console.Write("Enter Quantity: ");
                    qt = Convert.ToInt32(Console.ReadLine());
                    order_price.Add(price[11]);
                    price[11] *= qt;
                    total += price[11];
                    quanty.Add(qt);
                    Console.WriteLine("-----------ENTER A NEW PRODUCT ID OR TYPE 0 IF DONE-------------");
                    price[11] = 40;
                }
                else if (x == 13)
                {
                    order.Add(cate[12]);
                    Console.Write("Enter Quantity: ");
                    qt = Convert.ToInt32(Console.ReadLine());
                    order_price.Add(price[12]);
                    quanty.Add(qt);
                    price[12] *= qt;
                    total += price[12];
                    Console.WriteLine("-----------ENTER A NEW PRODUCT ID OR TYPE 0 IF DONE-------------");
                    price[12] = 50;
                }
                else if (x == 14)
                {
                    order.Add(cate[13]);
                    Console.Write("Enter Quantity: ");
                    qt = Convert.ToInt32(Console.ReadLine());
                    order_price.Add(price[13]);
                    price[13] *= qt;
                    total += price[13];
                    quanty.Add(qt);
                    Console.WriteLine("-----------ENTER A NEW PRODUCT ID OR TYPE 0 IF DONE-------------");
                    price[13] = 90;
                }
                else if (x == 15)
                {
                    order.Add(cate[14]);
                    Console.Write("Enter Quantity: ");
                    qt = Convert.ToInt32(Console.ReadLine());
                    order_price.Add(price[14]);
                    price[14] *= qt;
                    total += price[14];
                    quanty.Add(qt);
                    Console.WriteLine("-----------ENTER A NEW PRODUCT ID OR TYPE 0 IF DONE-------------");
                    price[14] = 45;
                }
                else if (x == 16)
                {
                    order.Add(cate[15]);
                    Console.Write("Enter Quantity: ");
                    qt = Convert.ToInt32(Console.ReadLine());
                    order_price.Add(price[15]);
                    price[15] *= qt;
                    total += price[15];
                    quanty.Add(qt);
                    Console.WriteLine("-----------ENTER A NEW PRODUCT ID OR TYPE 0 IF DONE-------------");
                    price[15] = 35;
                }
                else if (x == 17)
                {
                    order.Add(cate[16]);
                    Console.Write("Enter Quantity: ");
                    qt = Convert.ToInt32(Console.ReadLine());
                    order_price.Add(price[16]);
                    price[16] *= qt;
                    total += price[16];
                    quanty.Add(qt);
                    Console.WriteLine("-----------ENTER A NEW PRODUCT ID OR TYPE 0 IF DONE-------------");
                    price[16] = 25;
                }
                else if (x == 18)
                {
                    order.Add(cate[17]);
                    Console.Write("Enter Quantity: ");
                    qt = Convert.ToInt32(Console.ReadLine());
                    order_price.Add(price[17]);
                    price[17] *= qt;
                    total += price[17];
                    quanty.Add(qt);
                    Console.WriteLine("-----------ENTER A NEW PRODUCT ID OR TYPE 0 IF DONE-------------");
                    price[17] = 40;
                }
                else if (x == 19)
                {
                    order.Add(cate[18]);
                    Console.Write("Enter Quantity: ");
                    qt = Convert.ToInt32(Console.ReadLine());
                    order_price.Add(price[18]);
                    price[18] *= qt;
                    total += price[18];
                    quanty.Add(qt);
                    Console.WriteLine("-----------ENTER A NEW PRODUCT ID OR TYPE 0 IF DONE-------------");
                    price[18] = 60;
                }
                else if (x == 20)
                {

                    order.Add(cate[19]);
                    Console.Write("Enter Quantity: ");
                    qt = Convert.ToInt32(Console.ReadLine());
                    order_price.Add(price[19]);
                    price[19] *= qt;
                    total += price[19];
                    quanty.Add(qt);
                    Console.WriteLine("-----------ENTER A NEW PRODUCT ID OR TYPE 0 IF DONE-------------");
                    price[19] = 65;
                }
                else if (x == 21)
                {
                    order.Add(cate[20]);
                    Console.Write("Enter Quantity: ");
                    qt = Convert.ToInt32(Console.ReadLine());
                    order_price.Add(price[20]);
                    price[20] *= qt;
                    total += price[20];
                    quanty.Add(qt);
                    Console.WriteLine("-----------ENTER A NEW PRODUCT ID OR TYPE 0 IF DONE-------------");
                    price[20] = 60;
                }
                else if (x == 22)
                {
                    order.Add(cate[21]);
                    Console.Write("Enter Quantity: ");
                    qt = Convert.ToInt32(Console.ReadLine());
                    order_price.Add(price[21]);
                    price[21] *= qt;
                    total += price[21];
                    quanty.Add(qt);
                    Console.WriteLine("-----------ENTER A NEW PRODUCT ID OR TYPE 0 IF DONE-------------");
                    price[21] = 50;
                }
                else if (x == 23)
                {
                    order.Add(cate[22]);
                    Console.Write("Enter Quantity: ");
                    qt = Convert.ToInt32(Console.ReadLine());
                    order_price.Add(price[22]);
                    price[22] *= qt;
                    total += price[22];
                    quanty.Add(qt);
                    Console.WriteLine("-----------ENTER A NEW PRODUCT ID OR TYPE 0 IF DONE-------------");
                    price[22] = 12;
                }
                else if (x == 24)
                {
                    order.Add(cate[23]);
                    Console.Write("Enter Quantity: ");
                    qt = Convert.ToInt32(Console.ReadLine());
                    order_price.Add(price[23]);
                    price[23] *= qt;
                    total += price[23];
                    quanty.Add(qt);
                    Console.WriteLine("-----------ENTER A NEW PRODUCT ID OR TYPE 0 IF DONE-------------");
                    price[23] = 20;
                }
                else if (x == 25)
                {
                    order.Add(cate[24]);
                    Console.Write("Enter Quantity: ");
                    qt = Convert.ToInt32(Console.ReadLine());
                    order_price.Add(price[24]);
                    price[24] *= qt;
                    total += price[24];
                    quanty.Add(qt);
                    Console.WriteLine("-----------ENTER A NEW PRODUCT ID OR TYPE 0 IF DONE-------------");
                    price[24] = 25;
                }
                else
                {
                    Console.WriteLine("-----------------INVALID NUMNER! PLS TRY AGAIN------------------");
                }
            }
            double amount;
            Console.WriteLine("The Total is: " + total); // shows total
            for (int b = 1; b < 2; b--)// for loop if the amount is not enough
            {
                Console.Write("Enter Amount: ");
                amount = Convert.ToDouble(Console.ReadLine());// seller will enter the amount of customer
                double change = amount - total;//will get the change of the customer
                if (amount < total)
                {
                    Console.WriteLine("The Amount is insufficient");
                }
                else
                {
                    Console.WriteLine("The Change is : P" + change);
                    Console.WriteLine("=======================================================");
                    string? nameseller = null;
                    string seller = nameseller ?? " ";// seller can enter null
                    Console.Write("Name Of Seller: ");
                    seller = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("================================================================");// receipt design
                    Console.WriteLine("------------------- Minerva's Sari-sari Store ------------------");
                    Console.WriteLine("---------------------------- RECEIPT ---------------------------");
                    Console.WriteLine("Items".PadRight(10) + "Price_Per_Quantity".PadLeft(32) + "Quantity".PadLeft(19)); //shows all list of items, price, and quantity 
                    for (int y = 0; y < order.Count; y++)
                    {
                        Console.WriteLine(order[y].PadRight(10) + "                    " + "P" + order_price[y] + "                       " + quanty[y] );
                    }
                    Console.WriteLine("================================================================");
                    Console.WriteLine("Total: P" + total);
                    Console.WriteLine("Amount: P" + amount);
                    Console.WriteLine("Change: P" + change);
                    Console.WriteLine("================================================================");
                    Console.WriteLine("Seller: " + seller);
                    Console.WriteLine("Date & Time: " + DateTime.Now);
                    Console.WriteLine("=========================== THANK YOU ==========================");
                    break;
                }
            }
        
        }catch (Exception e){// will reset if the seller did not put any number
            Console.WriteLine("PLS TYPE A NUMBER\nTHIS SYSTEM WILL RESET");
            Thread.Sleep(3000);
            Console.WriteLine("");
            design_forcatch();
            classif();
        }
      }
    public void design_forcatch()// design of receipt 
    {
        Console.WriteLine("--------------------- Minerva's Sari-sari Store ----------------------");
        Console.WriteLine("========================== RECEIPT SYSTEM ============================");
    }
 }
