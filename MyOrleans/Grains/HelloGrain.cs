using Orleans;
using System.Threading.Tasks;
using MyOrleans.Interfaces;

namespace MyOrleans.Grains
{   

    public class HelloGrain : Grain, IHello
    {      
        async Task<string> IHello.SayHello(string value)
        {
            System.Console.WriteLine(value);
            return await Task.FromResult($"{value}: Hellllo");
        }
    }


}