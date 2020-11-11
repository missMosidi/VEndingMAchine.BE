using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using VendingMachine.Application.Utilities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace VendingMachine.Application.BaseHandler
{
    public abstract class BaseAddRequestHandler<TEntity, TRequestDtoCore, TContext> :
        HandlerErrorMessages,
        IRequestHandler<TRequestDtoCore>
        where TEntity : class
        where TRequestDtoCore : IRequest
        where TContext : DbContext
    {

        private readonly TContext _context;
        private readonly IMapper _mapper;

        public BaseAddRequestHandler(TContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public virtual async Task<Unit> Handle(TRequestDtoCore request, CancellationToken cancellationToken)
        {
            var entity = this._mapper.Map<TEntity>(request);

            this._context.Attach<TEntity>(entity);

            this._context.Set<TEntity>().Add(entity);

            var success = await this._context.SaveChangesAsync(cancellationToken) > 0;

            return success ? Unit.Value : throw new Exception(AddErrorMessage);
        }
    }
}
