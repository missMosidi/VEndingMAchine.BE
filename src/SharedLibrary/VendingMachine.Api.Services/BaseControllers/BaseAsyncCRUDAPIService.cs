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
    public abstract class BaseAsyncCRUDAPIService<TAddRequestDto, TUpdateRequestDto, TDeleteRequestDto, TGetAllRequestDto, TGetRequestDto, TDto, TPrimaryKey> :
        BaseAPIServices
        where TAddRequestDto : new()
        where TUpdateRequestDto : new()
        where TDeleteRequestDto : new()
        where TGetAllRequestDto : new()
        where TGetRequestDto : new()
        where TDto : new()
    {
        public BaseAsyncCRUDAPIService(IMediator mediator, InternalServerResponse internalServerResponse) : base(mediator, internalServerResponse)
        {
        }

        [HttpGet, Route(EndPointRoutesParams.GETALL)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType(typeof(InternalServerResponse), (int)HttpStatusCode.InternalServerError)]
        public virtual async Task<ActionResult> GetAllAsync(CancellationToken cancellationToken)
        {
            try
            {
                var data = (List<TDto>) (await _mediator.Send(new TGetAllRequestDto(), cancellationToken));

                if (data == null || (int) data?.GetType().GetProperty("Count").GetValue(data) <= 0) return StatusCode((int)HttpStatusCode.NoContent);

                return Ok(new SuccessResponseList<List<TDto>>
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Results = new ResultResponse<List<TDto>>
                    {
                        TotalCount = (int)data?.GetType().GetProperty("Count").GetValue(data),
                        Item = data
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



        [HttpGet, Route(EndPointRoutesParams.GET_BY_ID)]
        [ProducesResponseType(typeof(SuccessResponse<string>), (int)HttpStatusCode.NoContent)]
        [ProducesResponseType(typeof(InternalServerResponse), (int)HttpStatusCode.InternalServerError)]
        public virtual async Task<ActionResult> GetByIDAsync(TPrimaryKey id, CancellationToken cancellationToken)
        {
            try
            {

                var getRequestDto = new TGetRequestDto();

                getRequestDto.GetType().GetProperty("Id").SetValue(getRequestDto, id);

                var data = await _mediator.Send(getRequestDto, cancellationToken);

                if (data == null)
                {
                    SuccessResponse<string> SuccessResponse = new SuccessResponse<string>();

                    SuccessResponse.StatusCode = (int)HttpStatusCode.NotFound;
                    SuccessResponse.Results = HttpResponseMessages.NotFoundMessage;
                    SuccessResponse.Success = true;
                    SuccessResponse.UnAuthorizedRequest = false;

                    return StatusCode(SuccessResponse.StatusCode, SuccessResponse);
                }

                return Ok(new SuccessResponse<TDto>
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Results = (TDto)data,
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



        [HttpPost, Route(EndPointRoutesParams.CREATE)]
        [ProducesResponseType(typeof(SuccessResponse<string>), (int)HttpStatusCode.Created)]
        [ProducesResponseType(typeof(SuccessResponse<string>), (int)HttpStatusCode.NotImplemented)]
        [ProducesResponseType(typeof(SuccessResponse<ModelStateDictionary>), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(InternalServerResponse), (int)HttpStatusCode.InternalServerError)]
        public virtual async Task<ActionResult> AddAsync([FromBody] TAddRequestDto value, CancellationToken cancellationToken)
        {
            try
            {
                var userIdCliam = User.Claims.FirstOrDefault(x => x.Type.Equals("Id"));

                if (userIdCliam != null)
                {
                    value.GetType().GetProperty("CreatorUserId").SetValue(value, Guid.Parse(userIdCliam.Value));
                }


                

                if (!ModelState.IsValid)
                {
                    SuccessResponse<ModelStateDictionary> SuccessResponse = new SuccessResponse<ModelStateDictionary>();

                    SuccessResponse.StatusCode = (int)HttpStatusCode.BadRequest;
                    SuccessResponse.Results = ModelState;
                    SuccessResponse.Success = true;
                    SuccessResponse.UnAuthorizedRequest = false;

                    return StatusCode(SuccessResponse.StatusCode, SuccessResponse);
                }

                var resault = await _mediator.Send(value, cancellationToken);

                this.successResponseCUDR.StatusCode = (int)HttpStatusCode.Created;
                this.successResponseCUDR.Results = HttpResponseMessages.CreatedMessage;

                return resault != null ? StatusCode(this.successResponseCUDR.StatusCode, this.successResponseCUDR) : StatusCode(this.successResponseNotImplemented.StatusCode, this.successResponseNotImplemented);

            }
            catch (Exception ex)
            {
                return StatusCode(this._internalServerResponse.StatusCode, this._internalServerResponse);
            }
        }


        [HttpPut, Route(EndPointRoutesParams.UPDATE)]
        [ProducesResponseType(typeof(SuccessResponse<string>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(SuccessResponse<string>), (int)HttpStatusCode.NotImplemented)]
        [ProducesResponseType(typeof(SuccessResponse<string>), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(InternalServerResponse), (int)HttpStatusCode.InternalServerError)]
        public virtual async Task<ActionResult> UpdateAsync(TPrimaryKey id, [FromBody] TUpdateRequestDto value, CancellationToken cancellationToken)
        {
            try
            {
                var userIdCliam = User.Claims.FirstOrDefault(x => x.Type.Equals("Id"));

                if (userIdCliam != null)
                {
                    value.GetType().GetProperty("LastModifierUserId").SetValue(value, Guid.Parse(userIdCliam.Value));
                }

                value.GetType().GetProperty("Id").SetValue(value, id);
                

                if (!ModelState.IsValid)
                {
                    SuccessResponse<ModelStateDictionary> SuccessResponse = new SuccessResponse<ModelStateDictionary>();

                    SuccessResponse.StatusCode = (int)HttpStatusCode.BadRequest;
                    SuccessResponse.Results = ModelState;
                    SuccessResponse.Success = true;
                    SuccessResponse.UnAuthorizedRequest = false;

                    return StatusCode(SuccessResponse.StatusCode, SuccessResponse);
                }

                var resault = await _mediator.Send(value, cancellationToken);

                this.successResponseCUDR.StatusCode = (int)HttpStatusCode.OK;
                this.successResponseCUDR.Results = HttpResponseMessages.UpdatedMessage;

                return resault != null ? StatusCode(this.successResponseCUDR.StatusCode, this.successResponseCUDR) : StatusCode(this.successResponseNotImplemented.StatusCode, this.successResponseNotImplemented);

            }
            catch (Exception ex)
            {
                return StatusCode(this._internalServerResponse.StatusCode, this._internalServerResponse);
            }
        }



        [HttpDelete, Route(EndPointRoutesParams.DELETE)]
        [ProducesResponseType(typeof(SuccessResponse<string>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(SuccessResponse<string>), (int)HttpStatusCode.NotImplemented)]
        [ProducesResponseType(typeof(SuccessResponse<string>), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(InternalServerResponse), (int)HttpStatusCode.InternalServerError)]
        public virtual async Task<ActionResult> DeleteAsync(TPrimaryKey id, CancellationToken cancellationToken)
        {
            try
            {
                var userIdCliam = User.Claims.FirstOrDefault(x => x.Type.Equals("Id"));

                var value = new TDeleteRequestDto();

                if (userIdCliam != null)
                {
                    value.GetType().GetProperty("DeleterUserId").SetValue(value, Guid.Parse(userIdCliam.Value));
                }

                value.GetType().GetProperty("Id").SetValue(value, id);
                

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
                this.successResponseCUDR.Results = HttpResponseMessages.DeletedMessage;

                return resault != null ? StatusCode(this.successResponseCUDR.StatusCode, this.successResponseCUDR) : StatusCode(this.successResponseNotImplemented.StatusCode, this.successResponseNotImplemented);

            }
            catch (Exception ex)
            {
                return StatusCode(this._internalServerResponse.StatusCode, this._internalServerResponse);
            }
        }
    }
}
