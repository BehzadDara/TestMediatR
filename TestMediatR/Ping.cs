using MediatR;

namespace TestMediatR
{
    public class Ping : IRequest<Pong>
    {
        public string Message { get; set; } = string.Empty;
    }
}
