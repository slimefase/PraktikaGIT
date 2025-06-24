using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika
{
    internal class Client : Person
    {
        public List<Order> Orders { get; set; } = new();
    }
}
