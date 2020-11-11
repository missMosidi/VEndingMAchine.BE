using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VendingMachine.Domain.Models.Interfaces.Common;
using VendingMachine.Domain.Models.Interfaces.Public;
using VendingMachine.Domain.Models.Models.Common;
using VendingMachine.Domain.Models.Utilities;

namespace VendingMachine.Domain.Models.Models.Public
{
    [Table("Products", Schema = FrameWorkSchemas.Public)]
    public class Product : StatusBaseFullAuditedEntity<Guid>, IProduct, IHasProductImage
    {
        
        public virtual ProductImage ProductImage { get; set; }
        
        [Required, StringLength(FrameWorkStandardEntityRules.ENTITY_LONG_NAME_LENGHT)]
        public virtual string ProductName { get; set; }

        [StringLength(FrameWorkStandardEntityRules.ENTITY_LONG_DESCRIPTION_LENGHT)]
        public virtual string? ProductDescription { get; set; }

        [Required, Column(TypeName = "decimal(18,2)")]
        public virtual decimal ProductPrice { get; set; }
    }
}
