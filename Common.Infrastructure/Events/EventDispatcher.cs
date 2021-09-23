﻿namespace Common.Infrastructure.Events
{
    using System;
    using System.Collections.Concurrent;
    using System.Reflection;
    using System.Threading.Tasks;
    using Common.Application;
    using Common.Domain;
    using Microsoft.Extensions.DependencyInjection;

    // TODO: make internal
    public class EventDispatcher : IEventDispatcher
    {
        private static readonly ConcurrentDictionary<Type, Type> HandlerTypesCache
            = new ConcurrentDictionary<Type, Type>();

        private static readonly ConcurrentDictionary<Type, Func<object, object, Task>> HandlersCache
            = new ConcurrentDictionary<Type, Func<object, object, Task>>();

        private static readonly Type HandlerType = typeof(IEventHandler<>);

        private static readonly MethodInfo MakeDelegateMethod = typeof(EventDispatcher)
            .GetMethod(nameof(MakeDelegate), BindingFlags.Static | BindingFlags.NonPublic)!;

        private static readonly Type EventHandlerFuncType = typeof(Func<Func<object, object, Task>>);

        private readonly IServiceProvider serviceProvider;

        public EventDispatcher(IServiceProvider serviceProvider)
            => this.serviceProvider = serviceProvider;

        public async Task Dispatch(IDomainEvent domainEvent)
        {
            var eventType = domainEvent.GetType();

            var handlerTypes = HandlerTypesCache.GetOrAdd(
                eventType,
                type => HandlerType.MakeGenericType(type));

            var eventHandlers = this.serviceProvider.GetServices(handlerTypes);

            foreach (var eventHandler in eventHandlers)
            {
                var handlerServiceType = eventHandler.GetType();

                var eventHandlerDelegate = HandlersCache.GetOrAdd(handlerServiceType, type =>
                {
                    var makeDelegate = MakeDelegateMethod
                        .MakeGenericMethod(eventType, type);

                    return ((Func<Func<object, object, Task>>)makeDelegate
                        .CreateDelegate(EventHandlerFuncType))
                        .Invoke();
                });

                await eventHandlerDelegate(domainEvent, eventHandler);
            }
        }

        private static Func<object, object, Task> MakeDelegate<TEvent, TEventHandler>()
            where TEvent : IDomainEvent
            where TEventHandler : IEventHandler<TEvent>
            => (domainEvent, eventHandler) =>
                ((TEventHandler)eventHandler).Handle((TEvent)domainEvent);
    }
}
