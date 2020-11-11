using VendingMachine.Api.Services.Responses.Commons;
using VendingMachine.Api.Services.Responses.Unsuccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Api.Services.Responses.Success
{
    public class SuccessResponseList<T> : UnsuccessResponse
    {
        public int StatusCode { get; set; }

        public ResultResponse<T> Results { get; set; }
    }
}
