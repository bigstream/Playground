using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wcfClient_dotNET.EchoServiceReferenceHTTP;

namespace wcfClient_dotNET
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            // Instantiate the Service wrapper specifying the binding and optionally the Endpoint URL. The BasicHttpBinding could be used instead.
            var client = new EchoServiceClient("BasicHttpBinding_IEchoService");
            var simpleResult = await client.EchoAsync("Hello");
            Console.WriteLine(simpleResult);

            var msg = new EchoMessage() { Text = "Hello2" };
            var msgResult = await client.ComplexEchoAsync(msg);
            Console.WriteLine(msgResult);
        }
    }
}
