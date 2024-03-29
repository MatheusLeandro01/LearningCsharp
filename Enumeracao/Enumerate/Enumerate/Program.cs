﻿using System;
using Enumerate.Entities;
using Enumerate.Entities.Enums;
namespace Enumerate
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString(); //Converter um valor de Enumeração para string, apenas utilize o ToString ao final;          
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}