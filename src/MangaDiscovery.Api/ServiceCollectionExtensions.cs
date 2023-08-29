using Microsoft.Extensions.DependencyInjection;

namespace MangaDiscovery.Api
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAnimeServices(this IServiceCollection serviceCollection)
        {
            return serviceCollection.AddSingleton<IAnimeService, CrunchyrollAnimeService>();
        }
    }
}
