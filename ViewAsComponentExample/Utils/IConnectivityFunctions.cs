using System.Threading.Tasks;

namespace ViewAsComponentExample
{
    public interface IConnectivityFunctions
    {
        Task<bool> IsConnected();
    }
}