using MiniNetflix.Identity.Data;
using MiniNetflix.Identity.Data.Models;
using MiniNetflix.Identity.Repositories.Interfaces;

namespace MiniNetflix.Identity.Repositories.Impl
{
    /// <inheritdoc />
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly ApplicationDbContext _context;

        public UserProfileRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public Task<UserProfile?> GetByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public Task<UserProfile> CreateAsync(UserProfile profile)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public Task<UserProfile> UpdateAsync(UserProfile profile)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public Task<bool> DeleteByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }
    }
}

