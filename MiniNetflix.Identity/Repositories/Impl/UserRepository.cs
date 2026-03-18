using Microsoft.EntityFrameworkCore;
using MiniNetflix.Identity.Data;
using MiniNetflix.Identity.Data.Models;
using MiniNetflix.Identity.Repositories.Interfaces;

namespace MiniNetflix.Identity.Repositories.Impl
{
    /// <inheritdoc />
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public async Task<User?> GetUserByEmailAsync(string email)
        {
            return await _context.Users
                .Include(u => u.Role)
                .FirstOrDefaultAsync(u => u.Email == email);
        }

        /// <inheritdoc />
        public async Task<User> CreateUserAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        /// <inheritdoc />
        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.Users
                .Include(u => u.Role)
                .FirstAsync(u => u.Id == id);
        }

        /// <inheritdoc />
        public async Task<User?> GetUserByUserIdAsync(Guid userId)
        {
            return await _context.Users
                .Include(u => u.Role)
                .FirstOrDefaultAsync(u => u.UserId == userId);
        }

        /// <inheritdoc />
        public Task UpdatePasswordHashAsync(int id, string passwordHash)
        {
            // TODO (студенты): найти пользователя по id, обновить PasswordHash и вызвать SaveChangesAsync().
            throw new NotImplementedException();
        }
    }
}
