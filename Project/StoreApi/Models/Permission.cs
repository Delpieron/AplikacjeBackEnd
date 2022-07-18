using StoreApi.Enums;

namespace StoreApi.Model
{
    public class Permission
    {
        public int Id { get; set; }
        public PermissionEnum Name { get; set; }
        public bool ReadPermission { get; set; }
        public bool WritePermission { get; set; }
        public bool ModifyPermission { get; set; }
    }
}
