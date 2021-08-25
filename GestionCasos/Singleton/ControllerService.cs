using Negocios;
namespace GestionCasos.Singleton
{
    public class ControllerService : ManagerService
    {
        private ContadorNegocio cn = null;
        private InstitucionNegocio inst = null;
        private RevisionNegocio rn = null;
        private EntregaNegocio en = null;
        private EstadoNegocio esn = null;
        private RecepcionNegocio ren = null;
        private UsuarioNegocio un = null;

        public RevisionNegocio CrudCaso()
        {
            if (rn == null)
            {
                rn = new RevisionNegocio();
            }
            return rn;
        }


        public ContadorNegocio CrudContador()
        {
            if (cn == null)
            {
                cn = new ContadorNegocio();
            }
            return cn;
        }


        public EntregaNegocio CrudEntrega()
        {
            if (en == null)
            {
                en = new EntregaNegocio();
            }
            return en;
        }


        public EstadoNegocio CrudEstado()
        {
            if (esn == null)
            {
                esn = new EstadoNegocio();
            }
            return esn;
        }


        public InstitucionNegocio CrudJuntas()
        {
            if (inst == null)
            {
                inst = new InstitucionNegocio();
            }
            return inst;
        }


        public RecepcionNegocio CrudRecepcion()
        {
            if (ren == null)
            {
                ren = new RecepcionNegocio();
            }
            return ren;
        }


        public UsuarioNegocio CrudUsuario()
        {
            if (un == null)
            {
                un = new UsuarioNegocio();
            }
            return un;
        }
    }
}
