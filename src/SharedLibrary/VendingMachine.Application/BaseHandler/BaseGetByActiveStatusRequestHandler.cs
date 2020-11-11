using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace VendingMachine.Application.BaseHandler
{
    public abstract class BaseGetByActiveStatusRequestHandler<TEntity, TDtoCore, TRequestDtoCore, TContext> :
        IRequestHandler<TRequestDtoCore, List<TDtoCore>>
        where TEntity : class
        where TDtoCore : class
        where TRequestDtoCore : IRequest<List<TDtoCore>>
        where TContext : DbContext

    {
        private readonly TContext _context;
        private readonly IMapper _mapper;

        protected BaseGetByActiveStatusRequestHandler(TContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public virtual async Task<List<TDtoCore>> Handle(TRequestDtoCore request, CancellationToken cancellationToken)
        {
            var entityData = (await this._context
                .Set<TEntity>()
                .ToListAsync(cancellationToken))
                .Where(x => (bool)x.GetType().GetProperty("ActiveStatus").GetValue(x) == (bool)request.GetType().GetProperty("ActiveStatus").GetValue(request) && (bool)x.GetType().GetProperty("IsDeleted").GetValue(x) == false)
                .ToList();

            return this._mapper.Map<List<TEntity>, List<TDtoCore>>(entityData);
        }
    }
}
