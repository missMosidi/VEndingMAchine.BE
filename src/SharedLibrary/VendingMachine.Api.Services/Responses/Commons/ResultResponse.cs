using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Api.Services.Responses.Commons
{
    public class ResultResponse<T>
    {
        public long TotalCount { get; set; }

        public T Item { get; set; }
    }
}