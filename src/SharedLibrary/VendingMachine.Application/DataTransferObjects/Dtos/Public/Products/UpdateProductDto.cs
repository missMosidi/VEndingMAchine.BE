using System;
using System.ComponentModel.DataAnnotations;
using VendingMachine.Application.DataTransferObjects.Dtos.Common;
using VendingMachine.Application.DataTransferObjects.Interface.Public.Products;
using VendingMachine.Domain.Models.Utilities;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.Products
{
    public class UpdateProductDto : InputBaseEntityDto<Guid>, IUpdateProductDto
    {
        [Required, StringLength(FrameWorkStandardEntityRules.ENTITY_LONG_NAME_LENGHT)]
        public string ProductName { get; set; }

        [StringLength(FrameWorkStandardEntityRules.ENTITY_LONG_DESCRIPTION_LENGHT)]
        public string ProductDescription { get; set; }

        [Required]
        public decimal ProductPrice { get; set; }

        [Required]
        public long? StatusId { get; set; }
        
        [Required]
        public Guid? ProductImageId { get; set; }

        [System.Text.Json.Serialization.JsonIgnore, Newtonsoft.Json.JsonIgnore]
        public Guid? LastModifierUserId { get; set; }
        
    }
}
