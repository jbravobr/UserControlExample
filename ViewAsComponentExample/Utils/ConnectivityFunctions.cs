using System.Threading.Tasks;

namespace ViewAsComponentExample
{
    public class ConnectivityFunctions : IConnectivityFunctions
    {
        const string host = "www.google.com.br";

        public async Task<bool> IsConnected()
        {
            var isConnected = await Plugin.Connectivity.CrossConnectivity.Current.IsRemoteReachable(host);
            return isConnected;
        }

        public ConnectivityFunctions()
        { }
    }
}