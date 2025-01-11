using Grpc.Core;
using System.Threading.Tasks;

namespace GrpcServer;

public class GreeterService : Greeter.GreeterBase
{
    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        var reply = new HelloReply
        {
            Message = $"Hello, {request.Name}!"
        };
        return Task.FromResult(reply);
    }
}
