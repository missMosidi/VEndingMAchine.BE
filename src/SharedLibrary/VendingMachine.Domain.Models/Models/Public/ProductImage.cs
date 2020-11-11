using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VendingMachine.Domain.Models.Interfaces.Public;
using VendingMachine.Domain.Models.Models.Common;
using VendingMachine.Domain.Models.Utilities;

namespace VendingMachine.Domain.Models.Models.Public
{
    [Table("ProductImages", Schema = FrameWorkSchemas.Public)]
    public class ProductImage : StatusBaseFullAuditedEntity<Guid>, IProductImage
    {
        [Required, StringLength(FrameWorkStandardEntityRules.ENTITY_LONG_NAME_LENGHT)]
        public virtual string ImageName { get; set; }

        [Required]
        public virtual byte[] ImageData { get; set; }

        [StringLength(FrameWorkStandardEntityRules.ENTITY_LONG_DESCRIPTION_LENGHT)]
        public virtual string ImageDescription { get; set; }
    
    }
}
