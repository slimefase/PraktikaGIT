namespace Praktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Показать меню");
                Console.WriteLine("2. Создать заказ");
                Console.WriteLine("3. Показать заказы поваров");
                Console.WriteLine("4. Выход");

                var input = Console.ReadLine();
                Console.Clear();

                switch (input)
                {
                    case "1":
                        for (int i = 0; i < OrderManager.Menu.Count; i++)
                        {
                            var dish = OrderManager.Menu[i];
                            Console.WriteLine($"{i}: {dish.Name} - {dish.Price}р");
                        }
                        break;

                    case "2":
                        var client = new Client { Name = "Покупатель" };
                        Console.WriteLine("Введите номера блюд через запятую:");
                        var line = Console.ReadLine();
                        var indexes = line.Split(',').Select(s => int.Parse(s.Trim())).ToList();
                        var order = OrderManager.CreateOrder(client, indexes);
                        Console.WriteLine($"Заказ создан! Всего: {order.TotalPrice}р. Повар: {order.AssignedCook.Name}, Курьер: {order.AssignedCourier.Name}");
                        break;

                    case "3":
                        foreach (var cook in OrderManager.Cooks)
                        {
                            Console.WriteLine($"Повар {cook.Name}:");
                            foreach (var o in cook.OrdersToCook)
                            {
                                Console.WriteLine($" - Заказ {o.Id}, {o.Dishes.Count} блюд, Клиент: {o.Client.Name}");
                            }
                        }
                        break;

                    case "4":
                        return;

                    default:
                        Console.WriteLine("Неверный ввод.");
                        break;
                }

                Console.WriteLine("\nНажмите Enter для продолжения...");
                Console.ReadLine();
            }
        }
    }
}