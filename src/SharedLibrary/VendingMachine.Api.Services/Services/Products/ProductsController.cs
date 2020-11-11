using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;
using VendingMachine.Api.Services.BaseControllers;
using VendingMachine.Api.Services.Responses.Commons;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Products;
using VendingMachine.Domain.Models.Enums;

namespace VendingMachine.Api.Services.Services.Products
{
    public class ProductsController : BaseAsyncFullApiService<AddProductDto, UpdateProductDto, DeleteProductDto, RestoreProductDto, GetAllProductDto, GetProductDto, GetDeletedProductDto, GetProductByStatusCodeDto, GetProductByStatusIdDto, ProductDto, DetailedProductDto, Guid>,
        IProductsService
    {
        public ProductsController(IMediator mediator, InternalServerResponse internalServerResponse) : base(mediator, internalServerResponse)
        {
        }

        public override Task<ActionResult> GetAllAsync(CancellationToken cancellationToken)
        {
            return base.GetAllAsync(cancellationToken);
        }

        public override Task<ActionResult> GetByIDAsync(Guid id, CancellationToken cancellationToken)
        {
            return base.GetByIDAsync(id, cancellationToken);
        }

        public override Task<ActionResult> GetByStatusCodeAsync(StatusCode statusCode, CancellationToken cancellationToken)
        {
            return base.GetByStatusCodeAsync(statusCode, cancellationToken);
        }

        public override Task<ActionResult> GetByStatusIDAsync(long statusId, CancellationToken cancellationToken)
        {
            return base.GetByStatusIDAsync(statusId, cancellationToken);
        }

        public override Task<ActionResult> GetDeletedAsync(CancellationToken cancellationToken)
        {
            return base.GetDeletedAsync(cancellationToken);
        }

        public override Task<ActionResult> AddAsync([FromBody] AddProductDto value, CancellationToken cancellationToken)
        {
            return base.AddAsync(value, cancellationToken);
        }

        public override Task<ActionResult> UpdateAsync(Guid id, [FromBody] UpdateProductDto value, CancellationToken cancellationToken)
        {
            return base.UpdateAsync(id, value, cancellationToken);
        }

        public override Task<ActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            return base.DeleteAsync(id, cancellationToken);
        }

        public override Task<ActionResult> RestoreAsync(Guid id, CancellationToken cancellationToken)
        {
            return base.RestoreAsync(id, cancellationToken);
        }
    }
}
