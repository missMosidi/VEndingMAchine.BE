using VendingMachine.Api.Services.Responses.Commons;

namespace VendingMachine.Api.Services.Responses.Unsuccess
{
    public class UnsuccessResponse
    {
        public string TargetUrl { get; set; }

        public bool Success { get; set; }

        public Error Error { get; set; }

        public bool UnAuthorizedRequest { get; set; }
    }
}
