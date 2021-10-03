using Datos;
using Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;
using Utilidades.Interfaces;

namespace Negocios
{
    //Plantilla
    public class ContadorNegocio : ICrud<tPersona>
    {
       readonly DatosContador contador = new DatosContador();
        public bool eliminar(tPersona e)
        {
            e.Estado = false;
            return contador.eliminar(e);
        }

        public bool guardarAsync(tPersona e)
        {
            return contador.guardarAsync(e);
        }

        public bool guardar(tMensajero e)
        {

            return contador.guardar(e);
        }

        public bool modificar(tPersona e)
        {
            return contador.modificar(e);
        }

        public tPersona obtenerPorId(tPersona e)
        {
            return contador.obtenerPorId(e);
        }
        public async Task<tPersona> obtenerPorIdAsync(string e)
        {
            return await contador.obtenerPorIdAsync(e);
        }
        public async Task<List<tPersona>> obtenerTodo()
        {
            return await contador.obtenerTodo();
        }

      

        public bool GuardarTrabajador(tTrabajador e)
        {

            return contador.GuardarTrabajador(e);
        }

        public async Task<List<viewTrabajador>> obtenerTrabador(int tipo)
        {
            return await contador.obtenerTrabador(tipo);
        }
        public viewTrabajador obtenerTrabadorBy(string cedula)
        {
            return contador.obtenerTrabadorBy(cedula);
        }
        public tMensajero obtenerMBy(string cedula)
        {
            return contador.obtenerMBy(cedula);
        }
        public tTrabajador obtenerTrabador(string cedula)
        {
            return contador.obtenerTrabador(cedula);
        }
    }
}
