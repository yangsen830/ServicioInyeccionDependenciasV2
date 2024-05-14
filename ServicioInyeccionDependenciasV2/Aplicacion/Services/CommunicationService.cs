
using ServicioInyeccionDependenciasV2.Aplicacion.Dependencias;
using ServicioInyeccionDependenciasV2.Infraestructura.Senders;

namespace ServicioInyeccionDependenciasV2.Aplicacion.Services
{
    public class CommunicationService
    {
        private ISender _sender;
        public CommunicationService(ISender medio)
        {
            _sender = medio;
        }

        public void SendMessage(string email, string message)
        {
            _sender.SendMessage(email, message);
        }
    }
}
