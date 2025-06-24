using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika
{
    internal class Order : IDomainObject
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Client Client { get; set; }
        public Cook AssignedCook { get; set; }
        public Courier AssignedCourier { get; set; }
        public List<Dish> Dishes { get; set; } = new();
        public bool IsCooked { get; set; }
        public bool IsDelivered { get; set; }

        public decimal TotalPrice => Dishes.Sum(d => d.Price);
    }
}
