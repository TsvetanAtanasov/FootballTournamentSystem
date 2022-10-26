namespace Core.Domain
{
    using Microsoft.Extensions.DependencyInjection;

    public static class DomainConfiguration
    {
        public static IServiceCollection AddDomain<TAssemblyType>
            (this IServiceCollection services)
            => services
                .Scan(scan => scan
                    .FromAssemblyOf<TAssemblyType>()
                    .AddClasses(classes => classes
                        .AssignableTo(typeof(IFactory<>)))
                    .AsMatchingInterface()
                    .WithTransientLifetime());
    }
}