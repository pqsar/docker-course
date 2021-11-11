namespace PQS.DockerCourse.Workers.Consumers
{
    using System;
    using System.Threading.Tasks;
    using MassTransit;
    using Microsoft.Extensions.Logging;
    using PQS.DockerCourse.Messaging.Contracts;

    public class CheckInventoryConsumer :
        IConsumer<CheckInventory>
    {
        private readonly ILogger _log;
        public CheckInventoryConsumer(ILogger<CheckInventoryConsumer> log)
        {
            _log = log;
        }

        public Task Consume(ConsumeContext<CheckInventory> context)
        {
            _log.LogInformation($"PROCESANDO CHECKEO DE INVENTARIO SKU:{context.Message.Sku}");
            return context.RespondAsync(new InventoryStatus
            {
                Sku = context.Message.Sku,
                QuantityOnHand = new Random().Next(100)
            });
        }
    }
}
