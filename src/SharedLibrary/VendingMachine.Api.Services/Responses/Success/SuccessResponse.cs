using VendingMachine.Api.Services.Responses.Unsuccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Api.Services.Responses.Success
{
    public class SuccessResponse<T> : UnsuccessResponse
    {
        public int StatusCode { get; set; }

        public T Results { get; set; }
    }
}
