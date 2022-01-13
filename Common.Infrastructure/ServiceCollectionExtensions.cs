﻿namespace Core.Infrastructure
{
    using System;
    using MassTransit;
    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMessaging(
            this IServiceCollection services,
            params Type[] consumers)
        {
            services
                .AddMassTransit(mt =>
                {
                    consumers.ForEach(consumer => mt.AddConsumer(consumer));

                    mt.AddBus(bus => Bus.Factory.CreateUsingRabbitMq(rmq =>
                    {
                        rmq.Host("rabbitmq://localhost");

                        consumers.ForEach(consumer => rmq.ReceiveEndpoint(consumer.Name, endpoint =>
                        {
                            endpoint.ConfigureConsumer(bus, consumer);
                        }));
                    }));
                })
                .AddMassTransitHostedService();

            return services;
        }
    }
}