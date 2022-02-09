namespace Core.Infrastructure.Messages
{
    using Core.Domain.Models;
    using Hangfire;
    using MassTransit;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using System;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    public class MessagesHostedService : IHostedService
    {
        private readonly IRecurringJobManager recurringJob;
        private readonly DbContext data;
        private readonly IBus publisher;

        public MessagesHostedService(
            IRecurringJobManager recurringJob,
            IServiceProvider services, 
            IBus publisher)
        {
            this.recurringJob = recurringJob;
            this.publisher = publisher;

            this.data = services.CreateScope().ServiceProvider.GetService<DbContext>();
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            this.recurringJob.AddOrUpdate(
                nameof(MessagesHostedService),
                () => this.ProcessPendingMessages(),
                "*/5 * * * * *");

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
            => Task.CompletedTask;

        public void ProcessPendingMessages()
        {
            var messages = this.data
                .Set<Message>()
                .Where(m => !m.Published)
                .ToList();

            foreach (var message in messages)
            {
                this.publisher.Publish(message.Data, message.Type);

                message.MarkAsPublished();

                this.data.SaveChanges();
            }
        }
    }
}
