using System;

namespace VendingMachine.Api.Services.AuthModels
{
    public class AuthenticateResultModel
    {
        public bool Status { get; set; }

        public string Message { get; set; }

        public string AccessToken { get; set; }

        public DateTime? ExpireOn { get; set; }

        public Guid? UserId { get; set; }
        public Guid? PersonId { get; set; }
        public string DeviceName { get; set; }
    }
}
