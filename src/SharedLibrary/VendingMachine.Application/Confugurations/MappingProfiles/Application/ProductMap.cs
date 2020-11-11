using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Products;
using VendingMachine.Domain.Models.Models.Public;
using VendingMachine.Persistance.EntityFramework.Context;

namespace VendingMachine.Application.Confugurations.MappingProfiles.Application
{
    public class ProductMap : Profile
    {
        private readonly VendingMachineDbContext _context;

        public ProductMap()
        {
            this.Mapping();
        }

        public ProductMap(VendingMachineDbContext context)
        {
            this._context = context;

            this.Mapping();
        }

        public void Mapping()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(dto => dto.Status, option => option.MapFrom(entity => entity.Status))
                .ForMember(dto => dto.ProductImage, option => option.MapFrom(entity => entity.ProductImage));

            CreateMap<Product, DetailedProductDto>()
                .ForMember(dto => dto.Status, option => option.MapFrom(entity => entity.Status))
                .ForMember(dto => dto.ProductImage, option => option.MapFrom(entity => entity.ProductImage));

            CreateMap<AddProductDto, Product>()
                .ForMember(entity => entity.Status, option => option.MapFrom(dto => this._context.Set<Status>().AsNoTracking().SingleOrDefault(x => x.Id == dto.StatusId)))
                .ForMember(entity => entity.ProductImage, option => option.MapFrom(dto => this._context.Set<ProductImage>().AsNoTracking().SingleOrDefault(x => x.Id == dto.ProductImageId)));

            CreateMap<UpdateProductDto, Product>()
                .ForMember(entity => entity.Status, option => option.MapFrom(dto => this._context.Set<Status>().AsNoTracking().SingleOrDefault(x => x.Id == dto.StatusId)))
                .ForMember(entity => entity.ProductImage, option => option.MapFrom(dto => this._context.Set<ProductImage>().AsNoTracking().SingleOrDefault(x => x.Id == dto.ProductImageId)));

            CreateMap<DeleteProductDto, Product>();
            CreateMap<RestoreProductDto, Product>();
        }
    }
}
