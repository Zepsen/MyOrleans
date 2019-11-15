using Orleans;
using System.Threading.Tasks;
using MyOrleans.Interfaces;

namespace MyOrleans.Grains
{   

    public class HelloGrain : Grain, IHello
    {
        private readonly IClusterClient clusterClient;

        public HelloGrain(IClusterClient clusterClient)
        {            
            this.clusterClient = clusterClient;
        }
        async Task<string> IHello.SayHello(string value)
        {
            System.Console.WriteLine(value);

            var grain = clusterClient.GetGrain<IServerName>(0);
            var serverName = await grain.GetServerName();

            return await Task.FromResult($"{value}: \r\n Hello, my name is {serverName}");
        }
    }


}