using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika
{
    internal interface IDomainObject
    {
        Guid Id { get; set; }
    }

}
