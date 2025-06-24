using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika
{
    internal class OrderManager
    {
        public static List<Dish> Menu { get; } = new()
        {
            new Dish { Name = "Суп", Price = 150 },
            new Dish { Name = "Паста", Price = 250 },
            new Dish { Name = "Салат", Price = 100 }
        };

        public static List<Cook> Cooks { get; } = new()
        {
            new Cook { Name = "Иван" },
            new Cook { Name = "Мария" }
        };

        public static List<Courier> Couriers { get; } = new()
        {
            new Courier { Name = "Сергей" },
            new Courier { Name = "Анна" }
        };

        public static List<Order> Orders { get; } = new();

        public static Order CreateOrder(Client client, List<int> dishIndexes)
        {
            var dishes = dishIndexes
                .Where(i => i >= 0 && i < Menu.Count)
                .Select(i => Menu[i])
                .ToList();

            var cook = Cooks[new Random().Next(Cooks.Count)];
            var courier = Couriers[new Random().Next(Couriers.Count)];

            var order = new Order
            {
                Client = client,
                Dishes = dishes,
                AssignedCook = cook,
                AssignedCourier = courier
            };

            Orders.Add(order);
            cook.OrdersToCook.Add(order);
            courier.OrdersToDeliver.Add(order);
            client.Orders.Add(order);

            return order;
        }
    }
}
