using ServicioInyeccionDependenciasV2.Aplicacion.Dependencias;
using ServicioInyeccionDependenciasV2.Dominio;
using ServicioInyeccionDependenciasV2.Infraestructura.Repositories;

namespace ServicioInyeccionDependenciasV2.Aplicacion.Services
{
    public class CustomerService
    {
        private IRepository _repository;

        public CustomerService(IRepository repositorio)
        {
            _repository = repositorio;
        }

        public List<Customers> GetCustomers()
        {
            return _repository.GetCustomers();
        }
    }
}
