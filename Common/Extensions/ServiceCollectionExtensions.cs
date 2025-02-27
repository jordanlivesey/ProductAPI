using Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Common.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void WrapService(this IServiceCollection services, Type service, Type wrapperService)
        {
            // get the old service and remove it from the service collection
            var oldService = services.FirstOrDefault(s => s.ServiceType == service);
            services.Remove(oldService);

            // create wrapper service
            var objectFactory = ActivatorUtilities.CreateFactory(wrapperService, new[] { service });

            // add the service with the new wrapper
            services.Add(ServiceDescriptor.Describe(service, 
                s => objectFactory(s, new[] { ActivatorUtilities.GetServiceOrCreateInstance(s, oldService.ImplementationType) }), oldService.Lifetime));
        }
    }
}
