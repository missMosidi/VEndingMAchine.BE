using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VendingMachine.Domain.Models.Enums;

namespace VendingMachine.Application.BaseHandler
{
    public abstract class BaseGetByStatusCodeRequestHandler<TEntity, TDtoCore, TRequestDtoCore, TContext> : 
        IRequestHandler<TRequestDtoCore, List<TDtoCore>>
        where TEntity : class 
        where TDtoCore : class 
        where TRequestDtoCore : IRequest<List<TDtoCore>>
        where TContext : DbContext
    {
        private readonly TContext _context;
        private readonly IMapper _mapper;

        protected BaseGetByStatusCodeRequestHandler(TContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public virtual async Task<List<TDtoCore>> Handle(TRequestDtoCore request, CancellationToken cancellationToken)
        {
            var entityData = (await this._context
                    .Set<TEntity>()
                    .ToListAsync(cancellationToken))
                    .Where(x => (bool)x.GetType().GetProperty("IsDeleted").GetValue(x) == false && (StatusCode)x.GetType().GetProperty("Status").GetValue(x).GetType().GetProperty("StatusCode").GetValue(x.GetType().GetProperty("Status").GetValue(x)) == (StatusCode)request.GetType().GetProperty("StatusCode").GetValue(request))
                    .ToList();

            return this._mapper.Map<List<TEntity>, List<TDtoCore>>(entityData);
        }
    }
}
