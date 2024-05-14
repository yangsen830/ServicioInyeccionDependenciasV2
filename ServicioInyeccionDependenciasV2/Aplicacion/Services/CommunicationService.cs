
using ServicioInyeccionDependenciasV2.Infraestructura.Senders;

namespace ServicioInyeccionDependenciasV2.Aplicacion.Services
{
    public class CommunicationService
    {
        private EmailService _sender;
        public CommunicationService()
        {
            _sender = new EmailService();
        }

        public void SendMessage(string email, string message)
        {
            _sender.SendMessage(email, message);
        }
    }
}
