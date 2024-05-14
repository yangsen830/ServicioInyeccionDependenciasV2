using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioInyeccionDependenciasV2.Aplicacion.Dependencias
{
    public interface ISender
    {
        public void SendMessage(string medio, string message);

    }
}
