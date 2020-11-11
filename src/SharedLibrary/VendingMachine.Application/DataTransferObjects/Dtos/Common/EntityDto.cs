namespace VendingMachine.Application.DataTransferObjects.Dtos.Common
{
    public class EntityDto<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }
    }
}
