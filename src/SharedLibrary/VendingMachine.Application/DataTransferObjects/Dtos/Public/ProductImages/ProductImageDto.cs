using System;
using System.ComponentModel.DataAnnotations;
using VendingMachine.Application.DataTransferObjects.Dtos.Common;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Statuses;
using VendingMachine.Application.DataTransferObjects.Interface.Public.ProductImages;
using VendingMachine.Domain.Models.Utilities;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.ProductImages
{
    public class ProductImageDto : EntityDto<Guid>, IProductImageDto
    {
        public string ImageName { get; set; }
        public byte[] ImageData { get; set; }

        public string ImageDescription { get; set; }
        
        public StatusDto Status { get; set; }

    }
}
