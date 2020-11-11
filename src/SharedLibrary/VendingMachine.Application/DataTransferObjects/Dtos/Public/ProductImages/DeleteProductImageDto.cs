using System;
using System.ComponentModel.DataAnnotations;
using VendingMachine.Application.DataTransferObjects.Dtos.Common;
using VendingMachine.Application.DataTransferObjects.Interface.Public.ProductImages;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.ProductImages
{
    public class DeleteProductImageDto : InputBaseEntityDto<Guid>, IDeleteProductImageDto
    {
        [System.Text.Json.Serialization.JsonIgnore, Newtonsoft.Json.JsonIgnore]
        public Guid? DeleterUserId { get; set; }
    }
}
