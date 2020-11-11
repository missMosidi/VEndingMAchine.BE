using VendingMachine.Application.DataTransferObjects.DataTransferObjects.Interface.Public.Statuses;
using System;
using System.ComponentModel.DataAnnotations;
using VendingMachine.Application.DataTransferObjects.Dtos.Common;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.Statuses
{

    public class DeleteStatusDto: InputBaseEntityDto<long>, IDeleteStatusDto
    {
        [Required]
        public Guid? DeleterUserId { get ; set ; }
    }
}
