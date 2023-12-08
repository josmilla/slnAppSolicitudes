using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantenimiento.Solicitud.Dominio.Reposositorios
{
    public interface ISolicitudDeMantenimientoRepositorio
    {
        void Adicionar(SolicitudDeMantenimiento entidad);
    }
}
