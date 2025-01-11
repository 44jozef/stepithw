using Grpc.Core;
using GrpcServer;


var server = new Server
{
    Services = { Greeter.BindService(new GreeterService()) },
    Ports = { new ServerPort("localhost", 5169, ServerCredentials.Insecure) }
};
server.Start();
Console.WriteLine("Server listening on port 5169...");
Console.ReadKey();
server.ShutdownAsync().Wait();