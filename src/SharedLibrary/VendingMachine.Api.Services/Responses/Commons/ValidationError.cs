using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Api.Services.Responses.Commons
{
    public class ValidationError
    {
        public string Message { get; set; }

        public List<string> Members { get; set; }
    }
}
