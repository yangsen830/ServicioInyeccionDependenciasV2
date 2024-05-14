using ServicioInyeccionDependenciasV2.Dominio;
using ServicioInyeccionDependenciasV2.Infraestructura.Repositories;

namespace ServicioInyeccionDependenciasV2.Aplicacion.Services
{
    public class CustomerService
    {
        private CustomerRepository _repository;

        public CustomerService()
        {
            _repository = new CustomerRepository();
        }

        public List<Customers> GetCustomers()
        {
            return _repository.GetCustomers();
        }
    }
}
