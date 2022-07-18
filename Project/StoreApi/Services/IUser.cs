using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreApi.Services
{
    public interface IUser
    {
        public Task<List<User>> getUsers();
        public Task<User> getUser(int id);
        public Task<User> addUser(User user);
        public Task<bool> editUser(User user);
        public Task<bool> deleteUser(int id);
    }
}
