using ServicioInyeccionDependenciasV2.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioInyeccionDependenciasV2.Aplicacion.Dependencias
{
    public interface IRepository
    {
        public List<Customers> GetCustomers();
    }
}
