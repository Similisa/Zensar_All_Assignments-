using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
    /*2..Create a Class called Products with Productid, Product Name, Price. 
    Accept 10 Products, sort them based on the price, and display the sorted Products*/


namespace Assg4_2
{
    class products
    {
       public  int ProductId;
       public string ProductName;
       public float Price;      
    }


    class Program
    {
        static void Main(string[] args)
        {
                        
                SortedList<int, string> sl = new SortedList<int, string>()
                {
                                        {30000, "samsung"},
                                        {50000, "Redmi"},
                                        {10000, "Vivo"},
                                        {40000, "Realme"},
                                        {51000, "oppo"},
                                        {19000, "Apple"},
                                        {22000, "Xiomi"},
                                        {49000, "oneplus"},
                                        {58000, "Motorolla"},
                                        {91000, "MI"},

                };

                    foreach (KeyValuePair<int, string> kvp in sl)
                    Console.WriteLine("Price: {0}, Product: {1}", kvp.Key, kvp.Value);

                    Console.Read();
        }
    }
}
