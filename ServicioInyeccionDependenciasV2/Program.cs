using ServicioInyeccionDependenciasV2.Aplicacion.Services;

namespace ServicioInyeccionDependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerService = new CustomerService();

            var communicationService = new CommunicationService();

            var customers = customerService.GetCustomers();
<<<<<<< HEAD
            var message = "¡Hola! Su pedido ya está disponible para recoger. Gracias por usar nuestro servicio de mensajería";
=======
            var message = "¡Hola! Su pedido ya está disponible, se lo llevamos a casa. Gracias por usar nuestro servicio de email";
>>>>>>> 8e50ec1 (Change readme.md)
            foreach (var customer in customers)
            {
                communicationService.SendMessage(customer.Email, message);
            }
        }
    }
}