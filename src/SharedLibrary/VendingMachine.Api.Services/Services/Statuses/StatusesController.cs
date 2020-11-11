using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using VendingMachine.Api.Services.BaseControllers;
using VendingMachine.Api.Services.Responses.Commons;
using VendingMachine.Api.Services.Responses.Success;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Statuses;

namespace VendingMachine.Api.Services.Services.Statuses
{
    public class StatusesController :
        BaseAsyncActiveStatusApiService<AddStatusDto, UpdateStatusDto, DeleteStatusDto, RestoreStatusDto, GetAllStatusDto, GetStatusDto, GetStatusByActiveStatusDto, GetDeletedStatusDto, StatusDto, DetailedStatusDto, long>
    {

        public StatusesController(IMediator mediator, InternalServerResponse internalServerResponse) : base(mediator, internalServerResponse)
        {
        }



        /// <summary>
        /// Returns all  statuses in the system
        /// </summary>
        /// <response code="200">Successfull Returns all the statuses in the system</response>
        /// <response code="204">Successfull Returns all the statuses in the system, but not data at the moment</response>
        /// <response code="500">They is a problem with the internal Server, Could not process the request succesfully</response>

        [AllowAnonymous]
        [ProducesResponseType(typeof(SuccessResponseList<List<StatusDto>>), (int)HttpStatusCode.OK)]
        public override Task<ActionResult> GetAllAsync(CancellationToken cancellationToken)
        {
            return base.GetAllAsync(cancellationToken);
        }


        /// <summary>
        /// Returns a specific status by {id} in the system
        /// </summary>
        /// <response code="200">Successfull returns specific status by {id} in the system</response>
        /// <response code="204">Successfull returns specific status by {id} in the system, but no data found for the specified {id} at the moment</response>
        /// <response code="500">They is a problem with the internal Server, Could not process the request succesfully</response>

        [AllowAnonymous]
        [ProducesResponseType(typeof(SuccessResponse<StatusDto>), (int)HttpStatusCode.OK)]
        public override Task<ActionResult> GetByIDAsync(long id, CancellationToken cancellationToken)
        {
            return base.GetByIDAsync(id, cancellationToken);
        }



        /// <summary>
        /// Returns all statuses by {activeStatus} in the system
        /// </summary>
        /// <response code="200">Successfull Returns all statuses by {activeStatus} in the system</response>
        /// <response code="204">Successfull Returns all statuses by {activeStatus} in the system, but not data at the moment</response>
        /// <response code="500">They is a problem with the internal Server, Could not process the request succesfully</response>

        [AllowAnonymous]
        [ProducesResponseType(typeof(SuccessResponseList<List<DetailedStatusDto>>), (int)HttpStatusCode.OK)]
        public override Task<ActionResult> GetByActiveStatus(bool activeStatus, CancellationToken cancellationToken)
        {
            return base.GetByActiveStatus(activeStatus, cancellationToken);
        }


        /// <summary>
        /// Returns all deleted  statuses in the system
        /// </summary>
        /// <response code="200">Successfull Returns all deleted the statuses in the system</response>
        /// <response code="204">Successfull Returns all deleted the statuses in the system, but not data at the moment</response>
        /// <response code="500">They is a problem with the internal Server, Could not process the request succesfully</response>

        [AllowAnonymous]
        [ProducesResponseType(typeof(SuccessResponseList<List<DetailedStatusDto>>), (int)HttpStatusCode.OK)]
        public override Task<ActionResult> GetDeletedAsync(CancellationToken cancellationToken)
        {
            return base.GetDeletedAsync(cancellationToken);
        }

        /// <summary>
        /// Create a status in the system.
        /// </summary>
        /// <response code="201">Successfull create the status  in the system.</response>
        /// <response code="501">Successfull trys to create the status in the system but implementation of the requests could not be successful at the moment.</response>
        /// <response code="400">Unable to get content in to the system due to validation error.</response>
        /// <response code="500">They is a problem with the internal Server, Could not process the request succesfully.</response>

        [AllowAnonymous]
        public override Task<ActionResult> AddAsync([FromBody] AddStatusDto value, CancellationToken cancellationToken)
        {
            return base.AddAsync(value, cancellationToken);
        }



        /// <summary>
        /// Update a specific status by id in the system.
        /// </summary>
        /// <response code="200">Successfull updates the specified status by {id}  in the system.</response>
        /// <response code="501">Successfull trys to update the specified status by {id} in the system but implementation of the requests could not be successful at the moment.</response>
        /// <response code="400">Unable to get content in to the system due to validation error.</response>
        /// <response code="500">They is a problem with the internal Server, Could not process the request succesfully.</response>

        [AllowAnonymous]
        public override Task<ActionResult> UpdateAsync(long id, [FromBody] UpdateStatusDto value, CancellationToken cancellationToken)
        {
            return base.UpdateAsync(id, value, cancellationToken);
        }



        /// <summary>
        /// Delete a specific status by {id} in the system.
        /// </summary>
        /// <response code="200">Successfull delete the specific status by {id}  in the system.</response>
        /// <response code="501">Successfull trys to delete the status in the system but implementation of the requests could not be successful at the moment.</response>
        /// <response code="400">Unable to get content in to the system due to validation error.</response>
        /// <response code="500">They is a problem with the internal Server, Could not process the request succesfully.</response>
        
        [AllowAnonymous]
        public override Task<ActionResult> DeleteAsync(long id, CancellationToken cancellationToken)
        {
            return base.DeleteAsync(id, cancellationToken);
        }


        /// <summary>
        /// Restore a specific deleted status by {id} in the system.
        /// </summary>
        /// <response code="200">Successfull restore the deleted status  by {id} in the system.</response>
        /// <response code="501">Successfull trys to restore the deleted status in the system but implementation of the requests could not be successful at the moment.</response>
        /// <response code="400">Unable to perform the request operation in to the system due to validation error.</response>
        /// <response code="500">They is a problem with the internal Server, Could not process the request succesfully.</response>

        [AllowAnonymous]
        public override Task<ActionResult> RestoreAsync(long id, CancellationToken cancellationToken)
        {
            return base.RestoreAsync(id, cancellationToken);
        }


    }
}
