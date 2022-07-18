using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreApi.Services
{
    public class UserService : IUser
    {
        public UserService(DataContext dbcontext)
        {
            DbContext = dbcontext;
        }
        public DataContext DbContext { get; set; }

        public async Task<User> addUser(User user)
        {
            await DbContext.user.AddAsync(user);
            await DbContext.SaveChangesAsync();
            var newSser = await getUser(user.id);
            return newSser;
        }

        public async Task<User> getUser(int id)
        {
            return await DbContext.user.SingleOrDefaultAsync((x) => x.id == id);
        }
        public async Task<bool> editUser(User user)
        {
            DbContext.user.Update(user);
            return await DbContext.SaveChangesAsync() >= 0;
        }
        public async Task<bool> deleteUser(int id)
        {
            var user = await getUser(id);
            if (user == null) return false;
            DbContext.user.Remove(user);
            int result = await DbContext.SaveChangesAsync();
            return result >= 0;
        }

        public async Task<List<User>> getUsers()
        {
            return await DbContext.user.ToListAsync();
        }
    }
}
