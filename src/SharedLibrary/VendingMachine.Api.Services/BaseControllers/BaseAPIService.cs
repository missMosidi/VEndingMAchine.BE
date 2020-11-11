using VendingMachine.Api.Services.Messages;
using VendingMachine.Api.Services.Responses.Commons;
using VendingMachine.Api.Services.Responses.Success;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using VendingMachine.Api.Services.Utilities;

namespace VendingMachine.Api.Services.BaseControllers
{
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiVersion(ApiVersionHistrory.VERSION_ONE)]
    [Route(EndPointRoutesParams.BASE_END_POINT)]
    [Produces("application/json")]
    public abstract class BaseAPIServices : ControllerBase
    {
        protected readonly IMediator _mediator;
        protected readonly InternalServerResponse _internalServerResponse;

        protected SuccessResponse<string> successResponseCUDR;
        protected SuccessResponse<string> successResponseNotImplemented;


        public BaseAPIServices(IMediator mediator, InternalServerResponse internalServerResponse)
        {
            this._mediator = mediator;
            this._internalServerResponse = internalServerResponse;

            this.successResponseCUDR = new SuccessResponse<string>
            {
                Error = null,
                Results = null,
                StatusCode = 0,
                Success = true,
                TargetUrl = null,
                UnAuthorizedRequest = false,
            };

            this.successResponseNotImplemented = new SuccessResponse<string>
            {
                Error = null,
                Results = HttpResponseMessages.NotImplementedMessage,
                StatusCode = (int)HttpStatusCode.NotImplemented,
                Success = true,
                TargetUrl = null,
                UnAuthorizedRequest = false,
            };
        }
    }
}
