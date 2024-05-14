using ServicioInyeccionDependenciasV2.Aplicacion.Dependencias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioInyeccionDependenciasV2.Infraestructura.Senders
{
    internal class SMSService : ISender
    {
        public void SendMessage(string medio, string message)
        {
            Console.WriteLine("SMS sent to: " + medio + " with message: " + message);
        }
    }

}
