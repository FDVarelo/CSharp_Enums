using Enum_1.Entities;
using Enum_1.Entities.Enums;
using System;

namespace Enum_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 2121,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}