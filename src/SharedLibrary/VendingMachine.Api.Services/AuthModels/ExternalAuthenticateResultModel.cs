namespace VendingMachine.Api.Services.AuthModels
{
    public class ExternalAuthenticateResultModel
    {
        public string AccessToken { get; set; }

        public int ExpireInSeconds { get; set; }

        public bool WaitingForActivation { get; set; }
    }
}
