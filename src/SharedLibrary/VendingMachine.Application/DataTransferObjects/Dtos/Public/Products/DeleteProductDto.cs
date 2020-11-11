using System;
using VendingMachine.Application.DataTransferObjects.Dtos.Common;
using VendingMachine.Application.DataTransferObjects.Interface.Public.Products;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.Products
{
    public class DeleteProductDto : InputBaseEntityDto<Guid>, IDeleteProductDto
    {
        [System.Text.Json.Serialization.JsonIgnore, Newtonsoft.Json.JsonIgnore]
        public Guid? LastModifierUserId { get; set; }
    }
}
