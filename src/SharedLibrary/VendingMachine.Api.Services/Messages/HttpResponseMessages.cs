using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Api.Services.Messages
{
    public static class HttpResponseMessages
    {
        public static string InternalErrorMessage { get; set; }

        public static string NoContentMessage { get; set; }

        public static string NotFoundMessage { get; set; }

        public static string CreatedMessage { get; set; }

        public static string UpdatedMessage { get; set; }

        public static string RestoredMessage { get; set; }

        public static string DeletedMessage { get; set; }

        public static string NotImplementedMessage { get; set; }
    }
}
