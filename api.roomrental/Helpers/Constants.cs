namespace api.roomrental.Helpers

{
    public static class Constants
    {
        public static class Strings
        {

            public static class Roles
            {

                public const string SuperAdmin = "Super Admin";
                public const string Admin = "Admin";
                public const string Moderator = "Moderator";
                public const string User = "User";
            }

            public static class Policy
            {
                public const string ApiUser = "ApiUser";
                public const string ApiAdmin = "ApiAdmin";
                public const string ApiMoserator = "ApiModerator";

            }
            public static class JwtClaimIdentifiers
            {
                public const string Rol = "rol", Id = "id";
            }

            public static class JwtClaims
            {
                public const string ApiAccess = "api_access";
            }
        }
    }
}