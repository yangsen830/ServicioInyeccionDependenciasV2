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
            var message = "¡Hola! Su pedido ya está disponible para recoger. Gracias por usar nuestro servicio de email";
            foreach (var customer in customers)
            {
                communicationService.SendMessage(customer.Email, message);
            }
        }
    }
}