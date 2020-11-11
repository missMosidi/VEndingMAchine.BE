using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendingMachine.Api.Services.Configuration
{
    public class JWTConfigurations
    {
        public string Site { get; set; }

        public string SigningKey { get; set; }

        public string ExperyInYears { get; set; }

        //Full property accesses with validation.
        public string ExperyInHours { get; set; }

        public string ExperyInMintutes { get; set; }

        public string ExperyInSeconds { get; set; }

        public string ExperyInDays { get; set; }

        public string ExperyInMounths { get; set; }

    }
}
