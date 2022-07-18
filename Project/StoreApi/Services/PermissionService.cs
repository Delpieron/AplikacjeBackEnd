using Microsoft.EntityFrameworkCore;
using StoreApi.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreApi.Services
{
    public class PermissionService : IPermission
    {
        public PermissionService(DataContext dbcontext)
        {
            DbContext = dbcontext;
        }
        public DataContext DbContext { get; set; }

        public async Task<Permission> addPermission(Permission permission)
        {
            await DbContext.Permission.AddAsync(permission);
            await DbContext.SaveChangesAsync();
            var newSser = await getPermission(permission.Id);
            return newSser;
        }

        public async Task<Permission> getPermission(int id)
        {
            return await DbContext.Permission.SingleOrDefaultAsync((x) => x.Id == id);
        }
        public async Task<bool> editPermission(Permission permission)
        {
            DbContext.Permission.Update(permission);
            return await DbContext.SaveChangesAsync() >= 0;
        }
        public async Task<bool> deletePermission(int id)
        {
            var permission = await getPermission(id);
            if (permission == null) return false;
            DbContext.Permission.Remove(permission);
            int result = await DbContext.SaveChangesAsync();
            return result >= 0;
        }

        public async Task<List<Permission>> getPermissions()
        {
            return await DbContext.Permission.ToListAsync();
        }
    }
}
