using MassTransit;
using Shared.Models;
using System.Threading.Tasks;

namespace TicketProcessor.Microservice.Consumers
{
    public class TicketConsumer : IConsumer<Ticket>
    {
        // Simulates a ticket consumer
        public async Task Consume(ConsumeContext<Ticket> context)
        {
            var data = context.Message;

            // 1 - Validate received Ticket

            // 2 - Add to Database

            // 3 - Notify the User
        }
    }
}
