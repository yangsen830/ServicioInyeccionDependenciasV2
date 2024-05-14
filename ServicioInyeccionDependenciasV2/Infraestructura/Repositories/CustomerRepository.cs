using ServicioInyeccionDependenciasV2.Aplicacion.Dependencias;
using ServicioInyeccionDependenciasV2.Dominio;

namespace ServicioInyeccionDependenciasV2.Infraestructura.Repositories
{
    public class CustomerRepository : IRepository
    {
        private IDbConnection _connection;

        public CustomerRepository(IDbConnection conecion)
        {
            _connection = conecion;
        }

        public List<Customers> GetCustomers()
        {
            if (_connection.GetType() == typeof(MySQLConnection))
            {
                Console.WriteLine($"Connection is MySQL");
            }
            else if (_connection.GetType() == typeof(OracleConnection))
            {
                Console.WriteLine($"Connection is Oracle");
            }

            return new List<Customers>
                {
                    new Customers { ID = 1, Name = "John Doe", Email = "jonh@gmail.com", Phone="1234567890"},
                    new Customers { ID = 2, Name = "Jane Doe", Email = "jane@gmail.com", Phone="0987654321"}
                };
        }
    }
}
