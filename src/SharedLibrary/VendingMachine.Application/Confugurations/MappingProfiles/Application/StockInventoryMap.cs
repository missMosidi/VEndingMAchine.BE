using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.StockInventories;
using VendingMachine.Domain.Models.Models.Public;
using VendingMachine.Persistance.EntityFramework.Context;

namespace VendingMachine.Application.Confugurations.MappingProfiles.Application
{
    public class StockInventoryMap : Profile
    {
        private readonly VendingMachineDbContext _context;

        public StockInventoryMap()
        {
            this.Mapping();
        }

        public StockInventoryMap(VendingMachineDbContext context)
        {
            this._context = context;

            this.Mapping();
        }

        public void Mapping()
        {
            CreateMap<StockInventory, StockInventoryDto>()
                .ForMember(dto => dto.Product, option => option.MapFrom(entity => entity.Product))
                .ForMember(dto => dto.Status, option => option.MapFrom(entity => entity.Status));
            CreateMap<StockInventory, DetailedStockInventoryDto>()
                .ForMember(dto => dto.Product, option => option.MapFrom(entity => entity.Product))
                .ForMember(dto => dto.Status, option => option.MapFrom(entity => entity.Status));
            CreateMap<StockInventoryDto, StockInventory>()
                .ForMember(entity => entity.Product, option => option.MapFrom(dto => dto.Product))
                .ForMember(entity => entity.Status, option => option.MapFrom(dto => dto.Status));

            CreateMap<AddStockInventoryDto, StockInventory>()
                .ForMember(entity => entity.Product, option => option.MapFrom(dto => this._context.Set<Product>().AsNoTracking().SingleOrDefault(x => x.Id == dto.ProductId)))
                .ForMember(entity => entity.Status, option => option.MapFrom(dto => this._context.Set<Status>().AsNoTracking().SingleOrDefault(x => x.Id == dto.StatusId)));
            CreateMap<UpdateStockInventoryDto, StockInventory>()
                .ForMember(entity => entity.Product, option => option.MapFrom(dto => this._context.Set<Product>().AsNoTracking().SingleOrDefault(x => x.Id == dto.ProductId)))
                .ForMember(entity => entity.Status, option => option.MapFrom(dto => this._context.Set<Status>().AsNoTracking().SingleOrDefault(x => x.Id == dto.StatusId)));

            CreateMap<DeleteStockInventoryDto, StockInventory>();
            CreateMap<RestoreStockInventoryDto, StockInventory>();
        }
    }
}
