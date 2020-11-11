namespace VendingMachine.Api.Services.Utilities
{
    public static class EndPointRoutesParams
    {

        public const string BASE_END_POINT = "api/[controller]";

        public const string GETALL = "";

        public const string GET_BY_ID  = "{id}";

        public const string CREATE = "";

        public const string UPDATE  = "{id}";

        public const string DELETE = "{id}";

        public const string RESTORE  = "Restore/{id}";

        public const string GET_DELETED = "Deleted";

        public const string GET_BY_STATUS_CODE = "By/StatusCode/{statusCode}";

        public const string GET_BY_STATUS_ID = "By/Status/{statusId}";

        public const string GET_BY_ACTIVE_STATUS = "By/Active/Status/{activeStatus}";

        public const string Authenticate = "Authenticate";

        public const string SignOff = "SignOff";

        public const string GetExternalAuthenticationProviders = "GetExternalAuthenticationProviders";

        public const string ExternalAuthenticate = "ExternalAuthenticate";

        public const string GetCurrentPerson = "Current/Person";

        public const string GetCurrentPersonAddress = "Current/Person/Addresses";

        public const string GetCurrentPersonContact = "Current/Person/Contacts";

        public const string GetCurrentUserImage = "Current/UserImage";
    }
}
