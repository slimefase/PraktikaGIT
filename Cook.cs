using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika
{
    internal class Cook : Person
    {
        public List<Order> OrdersToCook { get; set; } = new();
    }
}
