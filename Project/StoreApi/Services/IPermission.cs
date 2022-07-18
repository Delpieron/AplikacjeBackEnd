using StoreApi.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreApi.Services
{
    public interface IPermission
    {
        public Task<List<Permission>> getPermissions();
        public Task<Permission> getPermission(int id);
        public Task<Permission> addPermission(Permission user);
        public Task<bool> editPermission(Permission user);
        public Task<bool> deletePermission(int id);
    }
}
