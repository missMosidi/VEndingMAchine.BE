using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Api.Services.Responses.Commons
{
    public  class InternalServerResponse
    {
        public  int StatusCode { get; set; }

        public  string Message { get; set; }

        public  string SubMessage { get; set; }

        public  List<string> Instructions { get; set; }
    }
}
