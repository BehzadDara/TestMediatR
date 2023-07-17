using MediatR;

namespace TestMediatR
{
    public class PingHandler : IRequestHandler<Ping, Pong>
    {
        public Task<Pong> Handle(Ping request, CancellationToken cancellationToken)
        {
            var response = new Pong { Response = $"Message = {request.Message}, Response = Pong!" };
            return Task.FromResult(response);
        }
    }
}
