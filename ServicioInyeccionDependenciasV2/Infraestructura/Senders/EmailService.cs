
using ServicioInyeccionDependenciasV2.Aplicacion.Dependencias;

namespace ServicioInyeccionDependenciasV2.Infraestructura.Senders
{
    public class EmailService : ISender
    {
        public void SendMessage(string medio, string message)
        {
            Console.WriteLine("Email sent to: " + medio + " with message: " + message);
        }
    }
}
