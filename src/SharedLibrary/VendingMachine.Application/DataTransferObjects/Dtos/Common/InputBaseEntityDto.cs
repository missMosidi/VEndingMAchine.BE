using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Common
{
    public class InputBaseEntityDto<TPrimaryKey>
    {
        [Required]
        [System.Text.Json.Serialization.JsonIgnore, Newtonsoft.Json.JsonIgnore]
        public TPrimaryKey Id { get; set; }
    }
}
