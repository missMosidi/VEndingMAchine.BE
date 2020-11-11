using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VendingMachine.Domain.Models.Enums;
using VendingMachine.Domain.Models.Utilities;

namespace VendingMachine.Application.BaseHandler
{
    public abstract class BaseGetAllRequestHandler<TEntity, TDtoCore, TGetAllDtoCore, TContext> : 
        IRequestHandler<TGetAllDtoCore, List<TDtoCore>> 
        where TEntity : class 
        where TDtoCore : class 
        where TGetAllDtoCore : IRequest<List<TDtoCore>>
        where TContext : DbContext
    {
        protected readonly TContext _context;
        protected readonly IMapper _mapper;

        protected BaseGetAllRequestHandler(TContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public virtual async Task<List<TDtoCore>> Handle(TGetAllDtoCore request, CancellationToken cancellationToken)
        {
            var entityData = (await this._context
                    .Set<TEntity>()
                    .ToListAsync(cancellationToken))
                    .Where(x => (bool)x.GetType().GetProperty("IsDeleted")?.GetValue(x) == false && StatusValidatedHelperClass.ValiodateVisablity((StatusCode)x.GetType().GetProperty("Status").GetValue(x).GetType().GetProperty("StatusCode").GetValue(x.GetType().GetProperty("Status").GetValue(x))))
                    .ToList();

            return this._mapper.Map<List<TEntity>, List<TDtoCore>>(entityData);
        }
    }
}
