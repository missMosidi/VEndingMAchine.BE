using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace VendingMachine.Application.BaseHandler
{
    public abstract class BaseGetDeletedRequestHandler<TEntity, TDtoCore, TRequest, TContext> : 
        IRequestHandler<TRequest, List<TDtoCore>>
        where TEntity : class 
        where TDtoCore : class 
        where TRequest : IRequest<List<TDtoCore>>
        where TContext : DbContext
    {
        private readonly TContext _context;
        private readonly IMapper _mapper;

        protected BaseGetDeletedRequestHandler(TContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public virtual async Task<List<TDtoCore>> Handle(TRequest request, CancellationToken cancellationToken)
        {
            var entityData = (await this._context
                    .Set<TEntity>()
                    .ToListAsync())
                    .Where(x => (bool)x.GetType().GetProperty("IsDeleted").GetValue(x) == true)
                    .ToList();

            return this._mapper.Map<List<TEntity>, List<TDtoCore>>(entityData);
        }
    }
}
