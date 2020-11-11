using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VendingMachine.Domain.Models.Interfaces.Common;
using VendingMachine.Domain.Models.Interfaces.Public;
using VendingMachine.Domain.Models.Models.Common;
using VendingMachine.Domain.Models.Utilities;

namespace VendingMachine.Domain.Models.Models.Public
{
    [Table("StockInventories", Schema = FrameWorkSchemas.Public)]
    public class StockInventory : StatusBaseFullAuditedEntity<Guid>, IStockInventory, IHasProduct
    {
        [Required]
        public virtual int TotalItems { get; set; }
        
        [Required, DefaultValue(false)]
        public virtual bool IsOutOfStock { get; set; }

        [Required]
        public virtual Product Product { get; set; }
    }
}
