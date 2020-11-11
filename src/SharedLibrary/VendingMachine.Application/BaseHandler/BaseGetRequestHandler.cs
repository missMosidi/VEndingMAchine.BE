using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VendingMachine.Domain.Models.Enums;
using VendingMachine.Domain.Models.Utilities;

namespace VendingMachine.Application.BaseHandler
{
    public abstract class BaseGetRequestHandler<TEntity, TDtoCore, TRequestDtoCore, TContext> :
        IRequestHandler<TRequestDtoCore, TDtoCore>
        where TEntity : class 
        where TDtoCore : class
        where TRequestDtoCore : IRequest<TDtoCore>
        where TContext : DbContext
    {
        protected readonly TContext _context;
        protected readonly IMapper _mapper;

        protected BaseGetRequestHandler(TContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public virtual async Task<TDtoCore> Handle(TRequestDtoCore request, CancellationToken cancellationToken)
        {
            var entityData = (await this._context
                    .Set<TEntity>()
                    .ToListAsync())
                    .Where(x =>(bool)x.GetType().GetProperty("IsDeleted").GetValue(x) == false && StatusValidatedHelperClass.ValiodateVisablity((StatusCode)x.GetType().GetProperty("Status").GetValue(x).GetType().GetProperty("StatusCode").GetValue(x.GetType().GetProperty("Status").GetValue(x))) && x.GetType().GetProperty("Id").GetValue(x) == request.GetType().GetProperty("Id").GetValue(x))
                    .FirstOrDefault();

            return this._mapper.Map<TDtoCore>(entityData);
        }
    }
}
