using System;
using System.ComponentModel.DataAnnotations;
using VendingMachine.Application.DataTransferObjects.Interface.Public.ProductImages;
using VendingMachine.Domain.Models.Utilities;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.ProductImages
{
    public class AddProductImageDto : IAddProductImageDto
    {
        [Required, StringLength(FrameWorkStandardEntityRules.ENTITY_LONG_NAME_LENGHT)]
        public string ImageName { get; set; }

        [Required]
        public byte[] ImageData { get; set; }
        
        [StringLength(FrameWorkStandardEntityRules.ENTITY_LONG_DESCRIPTION_LENGHT)]
        public string ImageDescription { get; set; }

        [Required]
        public long? StatusId { get; set; }


        [System.Text.Json.Serialization.JsonIgnore, Newtonsoft.Json.JsonIgnore]
        public Guid? LastModifierUserId { get; set; }
    }
}
