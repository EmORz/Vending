using System;

namespace Vending
{
    class Vending
    {
        static void Main(string[] args)
        {
            var mesages = Labels.Messages();
            Console.WriteLine(mesages[0]);
            Products.Choose();
            byte userChoosen = byte.Parse(Console.ReadLine());
            var n = Products.User(userChoosen);
            Console.WriteLine(n);
            byte quantity = byte.Parse(Console.ReadLine());
            var bill = Products.FinalPrice(quantity);
            Console.WriteLine($"{mesages[6]} {bill:f2} {mesages[3]}");
            Console.WriteLine(mesages[1]);
            double inputMoney = double.Parse(Console.ReadLine());
            bool exactMoney = CheckBill(inputMoney, bill);
            var resto = inputMoney - bill;
            if (exactMoney)
            {
                Console.WriteLine(mesages[2]);
                Console.WriteLine($"{mesages[4]} {resto:f2} {mesages[3]}");
            }
            else
            {
                Console.WriteLine($"{mesages[5]}"+Math.Abs(resto)+$" {mesages[3]}");
            }
            Console.ReadKey();

        }
        private static bool CheckBill(double inputMoney, double bill)
        {
            return inputMoney>=bill;
        }
    }
}
