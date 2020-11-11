using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using VendingMachine.Application.Utilities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace VendingMachine.Application.BaseHandler
{
    public class BaseRestoreRequestHandler<TEntity, TDtoCore, TRequestDtoCore, TContext> : 
        HandlerErrorMessages, 
        IRequestHandler<TRequestDtoCore, TDtoCore>
        where TEntity : class 
        where TDtoCore : class 
        where TRequestDtoCore : IRequest<TDtoCore>
        where TContext : DbContext
    {
        private readonly TContext _context;
        private readonly IMapper _mapper;

        public BaseRestoreRequestHandler(TContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public virtual async Task<TDtoCore> Handle(TRequestDtoCore request, CancellationToken cancellationToken)
        {
            var data = await this._context.Set<TEntity>().FindAsync(request.GetType().GetProperty("Id").GetValue(request));

            if (data == null) return null;

            this._context.Entry(data).State = EntityState.Detached;

            var entity = this._mapper.Map<TRequestDtoCore, TEntity>(request, data);

            if(entity.GetType().GetProperty("IsDeleted") != null) entity.GetType().GetProperty("IsDeleted").SetValue(entity, false);
            if(entity.GetType().GetProperty("DeleterUserId") != null) entity.GetType().GetProperty("DeleterUserId").SetValue(entity, null);
            if(entity.GetType().GetProperty("DeletionTime") != null) entity.GetType().GetProperty("DeletionTime").SetValue(entity, null);
            if(entity.GetType().GetProperty("ModicationTime") != null) entity.GetType().GetProperty("ModicationTime").SetValue(entity, DateTime.Now);

            this._context.Attach<TEntity>(entity);

            this._context.Set<TEntity>().Update(entity);

            var success = await this._context.SaveChangesAsync(cancellationToken) > 0;

            return success ? this._mapper.Map<TDtoCore>(entity) : throw new Exception(RestoreErrorMessage);
        }
    }
}
