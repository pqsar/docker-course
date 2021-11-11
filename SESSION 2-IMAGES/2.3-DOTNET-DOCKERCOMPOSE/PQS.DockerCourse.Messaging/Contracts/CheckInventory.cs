using System;

namespace PQS.DockerCourse.Messaging.Contracts
{
    public record CheckInventory
    {
        public string Sku { get; init; }
    }
}
