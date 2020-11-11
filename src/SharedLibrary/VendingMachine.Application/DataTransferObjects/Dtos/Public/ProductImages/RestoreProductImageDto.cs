using System;
using VendingMachine.Application.DataTransferObjects.Dtos.Common;
using VendingMachine.Application.DataTransferObjects.Interface.Public.ProductImages;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.ProductImages
{
    public class RestoreProductImageDto : InputBaseEntityDto<Guid>, IRestoreProductImageDto
    {
        [System.Text.Json.Serialization.JsonIgnore, Newtonsoft.Json.JsonIgnore]
        public Guid? LastModifierUserId { get; set; }
    }
}
