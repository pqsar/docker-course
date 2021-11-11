using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PQS.DockerCourse.Messaging.Contracts
{
    public record InventoryStatus
    {
        public string Sku { get; init; }
        public int QuantityOnHand { get; init; }
    }
}
