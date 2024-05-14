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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            var message = "¡Hola! Su pedido ya está disponible para recoger. Gracias por usar nuestro servicio de mensajería";
=======
            var message = "¡Hola! Su pedido ya está disponible, se lo llevamos a casa. Gracias por usar nuestro servicio de email";
>>>>>>> 8e50ec1 (Change readme.md)
=======
            var message = "¡Hola! Su pedido ya está disponible para recoger. Gracias por usar nuestro servicio de mensajería";
=======
            var message = "¡Hola! Su pedido ya está disponible, se lo llevamos a casa. Gracias por usar nuestro servicio de email";
>>>>>>> f27951d (Añadir Interfaces)

>>>>>>> f2c84dc (Add minor changes)
            foreach (var customer in customers)
            {
                communicationService.SendMessage(customer.Email, message);
            }
        }
    }
}