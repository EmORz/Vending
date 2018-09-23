using System;

namespace Vending
{
    class Products
    {
        private static string[] products = {"tea", "coffee - normal", "coffee - long", "milk" };
        private static double[] prices = { 0.5, 1.5, 2.1, 1.0 };
        private static double temporal = 0;
        public Products() { }

        public static void Choose()
        {
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(i+" "+products[i]);
            }
        }        
        public static string User(byte numer)
        {
            var temp = "";
            while (numer>products.Length)
            {
                int b = products.Length;
                b--;
                Console.WriteLine("Въведохте грешна номерация! предлаганите продукти са между 0 и "+b );
                Console.WriteLine("Опитайте отново!");
                numer = byte.Parse(Console.ReadLine());
            }
            for (int i = 0; i < products.Length; i++)
            {
                if (numer == i)
                {
                    temp = $"Ти избра =>" + products[i] + $" с цена {prices[i]:f2} лв. за брой!\nИзберете количество";
                    temporal = prices[i];
                    break;
                }
            }              
            
            return temp;
        }
        public static double FinalPrice(byte quantity)
        {
            var temp = temporal * quantity;
            return temp;
        }
    }
}
