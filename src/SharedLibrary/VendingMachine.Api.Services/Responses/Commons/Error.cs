using System.Collections.Generic;

namespace VendingMachine.Api.Services.Responses.Commons
{
    public class Error
    {
        public string Code { get; set; }

        public string Details { get; set; }

        public List<ValidationError> validationErrors { get; set; }
    }
}
