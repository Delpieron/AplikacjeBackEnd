namespace StoreApi
{
    public static class ApiRoutes
    {
        public const string Base = "api/v1/";

        public static class User
        {
            public const string GetUsers = Base + "User";
            public const string GetUserId = Base + "User/{id}";
            public const string AddUserId = Base + "User";
            public const string EditUserId = Base + "User";
            public const string DeleteUserId = Base + "User/{id}";
            public const string SendMail = Base + "User";
        }
        public static class Permission
        {
            public const string GetPermissions = Base + "Permission";
            public const string GetPermissionId = Base + "Permission/{id}";
            public const string AddPermissionId = Base + "Permission";
            public const string EditPermissionId = Base + "Permission";
            public const string DeletePermissionId = Base + "Permission/{id}";
        }
        public static class Car
        {
            public const string GetCars = Base + "Car";
            public const string GetCarId = Base + "Car/{id}";
            public const string AddCarId = Base + "Car";
            public const string EditCarId = Base + "Car";
            public const string DeleteCarId = Base + "Car/{id}";
        }
        public static class CarParts
        {
            public const string GetCarParts = Base + "CarParts";
            public const string GetCarPartsId = Base + "CarParts/{id}";
            public const string AddCarPartsId = Base + "CarParts";
            public const string EditCarPartsId = Base + "CarParts";
            public const string DeleteCarPartsId = Base + "CarParts/{id}";
        }
    }
}
