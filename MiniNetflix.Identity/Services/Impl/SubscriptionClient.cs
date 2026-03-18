using MiniNetflix.Identity.DTOs;
using MiniNetflix.Identity.Services.Interfaces;

namespace MiniNetflix.Identity.Services.Impl
{
    /// <inheritdoc />
    public class SubscriptionClient : ISubscriptionClient
    {
        private readonly HttpClient _httpClient;

        public SubscriptionClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <inheritdoc />
        public Task<SubscriptionDto?> GetSubscriptionAsync(Guid userId)
        {
            // TODO (студенты): описать контракт сервиса Subscription (маршрут, DTO) и реализовать HTTP-вызов.
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public Task<SubscriptionDto> ChangeSubscriptionAsync(Guid userId, ChangeSubscriptionRequestDto request)
        {
            // TODO (студенты): описать контракт сервиса Subscription (маршрут, DTO) и реализовать HTTP-вызов.
            throw new NotImplementedException();
        }
    }
}

