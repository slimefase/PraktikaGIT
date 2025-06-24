using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika
{
    internal class Person : IDomainObject
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
    }

}
