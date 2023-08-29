using Microsoft.Extensions.Logging;

namespace MangaDiscovery.Api
{
    public interface IAnimeService
    {
        Task Search(string searchedTitle);
    }

    internal class CrunchyrollAnimeService : IAnimeService
    {
        private readonly ILogger<CrunchyrollAnimeService> _logger;
        private readonly HttpClient _httpClient;

        public CrunchyrollAnimeService(ILogger<CrunchyrollAnimeService> logger, HttpClient httpClient)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        /// <inheritdoc />
        public Task Search(string searchedTitle)
        {
            throw new NotImplementedException();
        }

        private record SearchResult (int CurrentPage, bool HasNextPage, IEnumerable<MangaResult> results);

        private record MangaResult (string Id, string Title, string Image, string Cover, bool HasDub, bool HasSub, IEnumerable<string> Genres);
    }
}