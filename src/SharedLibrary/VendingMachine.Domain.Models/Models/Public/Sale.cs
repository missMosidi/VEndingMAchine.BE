using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VendingMachine.Domain.Models.Interfaces.Audited;
using VendingMachine.Domain.Models.Interfaces.Common;
using VendingMachine.Domain.Models.Interfaces.Public;
using VendingMachine.Domain.Models.Models.Common;
using VendingMachine.Domain.Models.Utilities;

namespace VendingMachine.Domain.Models.Models.Public
{
    [Table("Sales", Schema = FrameWorkSchemas.Public)]
    public class Sale : StatusBaseEntity<Guid>, ISale, IHasCreationTime, IHasProduct
    {
        [Required]
        public virtual int Quantity { get; set; }

        [Required, Column(TypeName = "decimal(18,2)")]
        public virtual decimal TotalAmount { get; set; }
        
        [Required, Column(TypeName = "decimal(18,2)")]
        public virtual  decimal Change { get; set; }
        
        [Required]
        public virtual Product Product { get; set; }
        
        [Required]
        public virtual DateTime CreationTime { get; set; }
    }
}
