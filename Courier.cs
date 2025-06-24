using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika
{
    internal class Courier : Person
    {
        public List<Order> OrdersToDeliver { get; set; } = new();
    }
}
