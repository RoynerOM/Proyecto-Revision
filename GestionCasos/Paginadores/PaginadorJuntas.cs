using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Negocios;
using GestionCasos.Singleton;
namespace GestionCasos.Paginadores
{
    public class PaginadorJuntas
    {
        int RegistrosPorPagina = 20;
        IEnumerable<tInstitucion> listaJuntas;
        Paginador<tInstitucion> paginador;
        readonly ControllerService controller = new ControllerService();

        public async Task<Paginador<tInstitucion>> PaginadorInst(int pagina = 1, string buscar = null, int codigo = 0)
        {
            int _TotalRegistros = 0;

            //Ontengo la lista de un servicio relacionado a un vehiculo
            listaJuntas = await controller.CrudJuntas().obtenerTodo();

            //Cantidad de registros 
            _TotalRegistros = listaJuntas.Count();

            //Divide las datos en grupos de de 10
            listaJuntas = listaJuntas.OrderBy(x => x.Codigo)
                                        .Skip((pagina - 1) * RegistrosPorPagina)
                                        .Take(RegistrosPorPagina).ToList();

            //Filtro por placa o Dueno
            if (!string.IsNullOrEmpty(buscar))
            {
                //Elimino los espacios vacios de la cadena
                var lista = await controller.CrudJuntas().obtenerTodo();
                var conincidencias = await controller.CrudJuntas().obtenerTodo();
                //Recargo los servicios
                listaJuntas = lista.OrderBy(x => x.Codigo)
                                    .Where(x => x.tPersona.Cedula.Contains(buscar) ||
                                    x.Nombre.Contains(buscar))
                                    .Skip((pagina - 1) * RegistrosPorPagina)
                                    .Take(RegistrosPorPagina).ToList();

                //Re calcula la cantidad de registros
                _TotalRegistros = conincidencias.
                                                Where(x => x.tPersona.Cedula.Contains(buscar) ||
                                                x.Nombre.Contains(buscar.ToUpper())).Count();
            }

            if (codigo > 0)
            {
                //Elimino los espacios vacios de la cadena
                var lista = await controller.CrudJuntas().obtenerTodo();

                //Recargo los servicios
                listaJuntas = lista.Where(x => x.Codigo == codigo).ToList();

                //Re calcula la cantidad de registros
                _TotalRegistros = listaJuntas.Count();
            }

            //Calculo de las paginas
            var _TotalPaginas = (int)Math.Ceiling((double)_TotalRegistros / RegistrosPorPagina);

            paginador = new Paginador<tInstitucion>()
            {
                RegistrosPorPagina = RegistrosPorPagina,
                TotalRegistros = _TotalRegistros,
                TotalPaginas = _TotalPaginas,
                PaginaActual = pagina,
                Resultado = listaJuntas,
            };
            return paginador;
        }
    }
}
