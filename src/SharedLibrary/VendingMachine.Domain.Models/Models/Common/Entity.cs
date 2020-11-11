namespace VendingMachine.Domain.Models.Models.Common
{
    public class Entity<TPrimaryKey>
    {
        public virtual TPrimaryKey Id {get; set;}
    }
}
