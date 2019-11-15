using Orleans;
using System.Threading.Tasks;

namespace MyOrleans.Interfaces
{
    public interface IServerName : IGrainWithIntegerKey
    {
        Task<string> GetServerName();
    }
}