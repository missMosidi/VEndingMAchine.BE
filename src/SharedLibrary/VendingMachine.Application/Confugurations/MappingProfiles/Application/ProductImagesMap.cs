using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.ProductImages;
using VendingMachine.Domain.Models.Models.Public;
using VendingMachine.Persistance.EntityFramework.Context;

namespace VendingMachine.Application.Confugurations.MappingProfiles.Application
{
    public class ProductImagesMap : Profile
    {
        private readonly VendingMachineDbContext _context;

        public ProductImagesMap()
        {
            this.Mapping();
        }

        public ProductImagesMap(VendingMachineDbContext context)
        {
            this._context = context;

            this.Mapping();
        }

        public void Mapping()
        {
            CreateMap<ProductImage, ProductImageDto>()
                .ForMember(dto => dto.Status, option => option.MapFrom(entity => entity.Status));
            CreateMap<ProductImage, DetailedProductImageDto>()
                .ForMember(dto => dto.Status, option => option.MapFrom(entity => entity.Status));

            CreateMap<AddProductImageDto, ProductImage>()
                .ForMember(entity => entity.Status, option => option.MapFrom(dto => this._context.Set<Status>().AsNoTracking().SingleOrDefault(x => x.Id == dto.StatusId)));
            CreateMap<UpdateProductImageDto, ProductImage>()
                .ForMember(entity => entity.Status, option => option.MapFrom(dto => this._context.Set<Status>().AsNoTracking().SingleOrDefault(x => x.Id == dto.StatusId)));

            CreateMap<DeleteProductImageDto, ProductImage>();
            CreateMap<RestoreProductImageDto, ProductImage>();
        }
    }
}
