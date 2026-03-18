using MiniNetflix.Identity.DTOs;
using MiniNetflix.Identity.Repositories.Interfaces;
using MiniNetflix.Identity.Services.Interfaces;

namespace MiniNetflix.Identity.Services.Impl
{
    /// <inheritdoc />
    public class UserProfileService : IUserProfileService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserProfileRepository _userProfileRepository;

        public UserProfileService(IUserRepository userRepository, IUserProfileRepository userProfileRepository)
        {
            _userRepository = userRepository;
            _userProfileRepository = userProfileRepository;
        }

        /// <inheritdoc />
        public Task<UserProfileDto?> GetAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public Task<UserProfileDto> CreateAsync(Guid userId, CreateUserProfileRequestDto request)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public Task<UserProfileDto> UpdateAsync(Guid userId, UpdateUserProfileRequestDto request)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public Task<bool> DeleteAsync(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}

