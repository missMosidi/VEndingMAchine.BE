using AutoMapper;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Statuses;
using VendingMachine.Domain.Models.Models.Public;
using VendingMachine.Persistance.EntityFramework.Context;

namespace VendingMachine.Application.Confugurations.MappingProfiles.Application
{
    public class StatusMap : Profile
    {
        private readonly VendingMachineDbContext _context;

        public StatusMap()
        {
            this.Mapping();
        }

        public StatusMap(VendingMachineDbContext context)
        {
            this._context = context;

            this.Mapping();
        }

        public  void Mapping()
        {
            CreateMap<Status, StatusDto>();
            CreateMap<Status, DetailedStatusDto>();
            CreateMap<StatusDto, Status>();
            CreateMap<AddStatusDto, Status>();
            CreateMap<UpdateStatusDto, Status>();
            CreateMap<DeleteStatusDto, Status>();
            CreateMap<RestoreStatusDto, Status>();
        }
    }
}
