using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using VendingMachine.Application.Utilities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace VendingMachine.Application.BaseHandler
{
    public abstract  class BaseUpdateRequestHandler<TEntity, TDtoCore, TUpdateDtoCore, TContext> :
        HandlerErrorMessages,
        IRequestHandler<TUpdateDtoCore, TDtoCore>
        where TEntity : class
        where TDtoCore : class
        where TUpdateDtoCore : IRequest<TDtoCore>
        where TContext : DbContext
    {

        private readonly TContext _context;
        private readonly IMapper _mapper;

        public BaseUpdateRequestHandler(TContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public virtual async Task<TDtoCore> Handle(TUpdateDtoCore request, CancellationToken cancellationToken)
        {
            var data = await this._context.Set<TEntity>().FindAsync(request.GetType().GetProperty("Id").GetValue(request));

            if (data == null) return null;

            this._context.Entry(data).State = EntityState.Detached;

            TEntity entity = this._mapper.Map<TUpdateDtoCore, TEntity>(request, data);

            this._context.Attach<TEntity>(entity);

            if(entity.GetType().GetProperty("ModicationTime") != null) entity.GetType().GetProperty("ModicationTime").SetValue(entity, DateTime.Now);

            this._context.Set<TEntity>().Update(entity);

            var success = await this._context.SaveChangesAsync() > 0;

            return success ? this._mapper.Map<TDtoCore>(entity) : throw new Exception(UpdateErrorMessage);
        }
    }
}
