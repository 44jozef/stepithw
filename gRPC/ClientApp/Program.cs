using Grpc.Net.Client;
using GrpcServer;
using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var handler = new HttpClientHandler()
        {
            AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate
        };

        using var channel = GrpcChannel.ForAddress("http://localhost:5169", new GrpcChannelOptions
        {
            HttpClient = new HttpClient(handler) { DefaultRequestVersion = System.Net.HttpVersion.Version20 }
        });

        var client = new Greeter.GreeterClient(channel);

        var request = new HelloRequest { Name = "World" };

        var reply = await client.SayHelloAsync(request);

        Console.WriteLine("Greeting: " + reply.Message);
    }
}