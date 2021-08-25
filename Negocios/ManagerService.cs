using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public interface ManagerService
    {
        ContadorNegocio CrudContador();
        InstitucionNegocio CrudJuntas();
        EntregaNegocio CrudEntrega();
        EstadoNegocio CrudEstado();
        RecepcionNegocio CrudRecepcion();
        RevisionNegocio CrudCaso();
        UsuarioNegocio CrudUsuario();
    }
}
