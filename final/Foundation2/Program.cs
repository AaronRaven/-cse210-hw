using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();
        Order order1 = new Order("Arunas Rancevas");
        order1.SetCustomerAddress("Fabijoniskes", "Vilnius", "Aukstaityja", "Lithuania");//self instert
        order1.AddProduct("Pusheen pillow", "Pillow-123", 10, 2);
        order1.AddProduct("Pusheen Gamer Lamp", "Lamp-123", 15, 2);
        orders.Add(order1);


        Order order2 = new Order("Aaron Ravenson");
        order2.SetCustomerAddress("Hollywood", "Los Angeles", "California", "USA");
        order2.AddProduct("Pusheen pillow", "Pillow-123", 10, 2);
        order2.AddProduct("Pusheen Gamer Lamp", "Lamp-123", 15, 2);
        orders.Add(order2);

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine("Total price of order including shipping: $" + order.CalculateTotalCost());
        }

    }
}
