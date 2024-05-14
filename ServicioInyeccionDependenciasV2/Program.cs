using ServicioInyeccionDependenciasV2.Aplicacion.Services;
using ServicioInyeccionDependenciasV2.Infraestructura.Repositories;
using ServicioInyeccionDependenciasV2.Infraestructura.Senders;

namespace ServicioInyeccionDependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var mysql = new OracleConnection();
            var repository = new CustomerRepository(mysql);
            var customerService = new CustomerService(repository);

            var email = new EmailService();
            var sms = new SMSService();
            var communicationService = new CommunicationService(sms);

            var customers = customerService.GetCustomers();
            var message = "¡Hola! Su pedido ya está disponible para recoger. Gracias por usar nuestro servicio de mensajería";

            foreach (var customer in customers)
            {
                communicationService.SendMessage(customer.Email, message);
            }
        }
    }
}