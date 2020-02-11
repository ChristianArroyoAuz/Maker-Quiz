using System.Collections.Generic;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Linq;
using System.Text;
using System;

namespace ObjetoRemoto
{
    public class Servidor
    {
        private static System.Threading.AutoResetEvent eventoTerminacion = new System.Threading.AutoResetEvent(false);

        public static void Main()
        {
            ServiceHost anfitrion = new ServiceHost(typeof(ObjetoRemoto));
            anfitrion.AddServiceEndpoint(typeof(IObjetorRemoto), new NetTcpBinding(), "net.tcp://localhost:8080");
            anfitrion.Open();
            eventoTerminacion.WaitOne();
            Console.WriteLine();
            anfitrion.Close();
            Console.WriteLine();
        }

        public static void StopServer()
        {
            eventoTerminacion.Set();
        }
    }
}