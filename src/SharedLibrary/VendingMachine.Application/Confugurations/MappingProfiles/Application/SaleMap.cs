using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Sales;
using VendingMachine.Domain.Models.Models.Public;
using VendingMachine.Persistance.EntityFramework.Context;

namespace VendingMachine.Application.Confugurations.MappingProfiles.Application
{
    public class SaleMap : Profile
    {
        private readonly VendingMachineDbContext _context;

        public SaleMap()
        {
            this.Mapping();
        }

        public SaleMap(VendingMachineDbContext context)
        {
            this._context = context;

            this.Mapping();
        }

        public void Mapping()
        {
            CreateMap<Sale, SaleDto>()
                .ForMember(dto => dto.Status, option => option.MapFrom(entity => entity.Status))
                .ForMember(dto => dto.Product, option => option.MapFrom(entity => entity.Product));
            CreateMap<Sale, DetailedSaleDto>()
                .ForMember(dto => dto.Status, option => option.MapFrom(entity => entity.Status))
                .ForMember(dto => dto.Product, option => option.MapFrom(entity => entity.Product));

            CreateMap<AddSaleDto, Sale>()
                .ForMember(entity => entity.Status, option => option.MapFrom(dto => this._context.Set<Status>().AsNoTracking().SingleOrDefault(x => x.Id == dto.StatusId)))
                .ForMember(entity => entity.Status, option => option.MapFrom(dto => this._context.Set<Product>().AsNoTracking().SingleOrDefault(x => x.Id == dto.ProductId)));
        }
    }
}
