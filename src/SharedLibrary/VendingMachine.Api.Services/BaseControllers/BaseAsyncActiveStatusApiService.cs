using VendingMachine.Api.Services.Messages;
using VendingMachine.Api.Services.Responses.Commons;
using VendingMachine.Api.Services.Responses.Success;
using VendingMachine.Api.Services.Utilities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace VendingMachine.Api.Services.BaseControllers
{
    public abstract class BaseAsyncActiveStatusApiService<TAddRequestDto, TUpdateRequestDto, TDeleteRequestDto, TRestoreRequestDto, TGetAllRequestDto, TGetRequestDto, TGetByActiveStatusRequestDto, TGetDeletedRequestDto, TDto, TDetailedDto , TPrimaryKey> :
        BaseAsyncCRUDAPIService<TAddRequestDto, TUpdateRequestDto, TDeleteRequestDto, TGetAllRequestDto, TGetRequestDto, TDto, TPrimaryKey>
        where TAddRequestDto : class, new()
        where TUpdateRequestDto : class, new()
        where TDeleteRequestDto : class, new()
        where TGetAllRequestDto : class, new()
        where TGetRequestDto : class, new()
        where TGetDeletedRequestDto : class, new()
        where TDto : class, new()
        where TDetailedDto : class, new()
        where TRestoreRequestDto : class, new()
        where TGetByActiveStatusRequestDto : class, new()
    {

        protected BaseAsyncActiveStatusApiService(IMediator mediator, InternalServerResponse internalServerResponse) : base(mediator, internalServerResponse)
        {
        }


        [HttpGet, Route(EndPointRoutesParams.GET_DELETED)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType(typeof(InternalServerResponse), (int)HttpStatusCode.InternalServerError)]
        public virtual async Task<ActionResult> GetDeletedAsync(CancellationToken cancellationToken)
        {
            try
            {
                var data = await _mediator.Send(new TGetDeletedRequestDto(), cancellationToken);

                if (data == null || (int)data?.GetType().GetProperty("Count").GetValue(data) <= 0) return StatusCode((int)HttpStatusCode.NoContent);

                return Ok(new SuccessResponseList<List<TDetailedDto>>
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Results = new ResultResponse<List<TDetailedDto>>
                    {
                        TotalCount = (int)data.GetType().GetProperty("Count").GetValue(data),
                        Item = (List<TDetailedDto>) data
                    },
                    Success = true,
                    UnAuthorizedRequest = false,
                    Error = null,
                    TargetUrl = null
                });
            }
            catch (Exception ex)
            {
                return StatusCode(this._internalServerResponse.StatusCode, this._internalServerResponse);
            }
        }


        [HttpGet, Route(EndPointRoutesParams.GET_BY_ACTIVE_STATUS)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType(typeof(InternalServerResponse), (int)HttpStatusCode.InternalServerError)]
        public virtual async Task<ActionResult> GetByActiveStatus(bool activeStatus, CancellationToken cancellationToken)
        {
            try
            {
                var value = new TGetByActiveStatusRequestDto();

                value.GetType().GetProperty("ActiveStatus").SetValue(value, activeStatus);

                var data =  await _mediator.Send(value, cancellationToken);

                if (data == null || (int)data?.GetType().GetProperty("Count").GetValue(data) <= 0) return StatusCode((int)HttpStatusCode.NoContent);

                return Ok(new SuccessResponseList<List<TDetailedDto>>
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Results = new ResultResponse<List<TDetailedDto>>
                    {
                        TotalCount = (int)data?.GetType().GetProperty("Count").GetValue(data),
                        Item = (List<TDetailedDto>) data
                    },
                    Success = true,
                    UnAuthorizedRequest = false,
                    Error = null,
                    TargetUrl = null
                });
            }
            catch (Exception ex)
            {
                return StatusCode(this._internalServerResponse.StatusCode, this._internalServerResponse);
            }
        }


        [HttpPut, Route(EndPointRoutesParams.RESTORE)]
        [ProducesResponseType(typeof(SuccessResponse<string>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(SuccessResponse<string>), (int)HttpStatusCode.NotImplemented)]
        [ProducesResponseType(typeof(SuccessResponse<string>), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(InternalServerResponse), (int)HttpStatusCode.InternalServerError)]
        public virtual async Task<ActionResult> RestoreAsync(TPrimaryKey id, CancellationToken cancellationToken)
        {
            try
            {
                var userIdCliam = User.Claims.FirstOrDefault(x => x.Type.Equals("Id"));

                if (userIdCliam == null)
                {
                    SuccessResponse<string> SuccessResponse = new SuccessResponse<string>();

                    SuccessResponse.StatusCode = (int)HttpStatusCode.Unauthorized;
                    SuccessResponse.Results = "The User ID Claim Was not Found From the claims Please Signin Again";
                    SuccessResponse.Success = false;
                    SuccessResponse.UnAuthorizedRequest = false;

                    return StatusCode(SuccessResponse.StatusCode, SuccessResponse);
                }


                var value = new TRestoreRequestDto();

                value.GetType().GetProperty("Id").SetValue(value, id);
                value.GetType().GetProperty("LastModifierUserId").SetValue(value, Guid.Parse(userIdCliam.Value));

                if (!ModelState.IsValid)
                {
                    SuccessResponse<ModelStateDictionary> SuccessResponse = new SuccessResponse<ModelStateDictionary>();

                    SuccessResponse.StatusCode = (int)HttpStatusCode.BadRequest;
                    SuccessResponse.Results = ModelState;
                    SuccessResponse.Success = true;
                    SuccessResponse.UnAuthorizedRequest = false;

                    return StatusCode((int)HttpStatusCode.BadRequest, ModelState);
                }

                var resault = await _mediator.Send(value, cancellationToken);

                this.successResponseCUDR.StatusCode = (int)HttpStatusCode.OK;
                this.successResponseCUDR.Results = HttpResponseMessages.RestoredMessage;

                return resault != null ? StatusCode(this.successResponseCUDR.StatusCode, this.successResponseCUDR) : StatusCode(this.successResponseNotImplemented.StatusCode, this.successResponseNotImplemented);

            }
            catch (Exception ex)
            {
                return StatusCode(this._internalServerResponse.StatusCode, this._internalServerResponse);
            }
        }
    }
}
