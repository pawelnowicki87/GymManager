using MediatR;
using Microsoft.Extensions.Logging;


namespace GymManager.Application.Common.Behaviours
{
    public class Loggingbehaviours<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        private readonly ILogger<TRequest> _logger;

        public Loggingbehaviours(ILogger<TRequest> logger)
        {
            _logger = logger;
        }
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            var requestName = typeof(TRequest).Name;

            _logger.LogInformation($"Handling {requestName}");
            _logger.LogInformation("GymManager Request: {@Name} {@Request}", requestName, request);

            var response = await next();

            _logger.LogInformation($"Handled {typeof(TResponse).Name}");

            return response;
        }
    }
}
