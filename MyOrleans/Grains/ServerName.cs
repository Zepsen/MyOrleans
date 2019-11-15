using System.Threading.Tasks;
using MyOrleans.Interfaces;
using Orleans;

namespace MyOrleans.Grains
{
    public class ServerName : Grain, IServerName
    {
        Task<string> IServerName.GetServerName()
        {
            return Task.FromResult("SuperServerName");
        }
    }
}
