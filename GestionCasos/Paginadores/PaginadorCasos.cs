using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using GestionCasos.Singleton;

namespace GestionCasos.Paginadores
{
    public class PaginadorCasos
    {
        int RegistrosPorPagina = 20;
        IEnumerable<tRevision> listaJuntas;
        Paginador<tRevision> paginador;
        readonly ControllerService controller = new ControllerService();

        public async Task<Paginador<tRevision>> PaginadorCaso(int pagina = 1, string buscar = null, int codigo = 0, string start = null, string end = null)
        {
            int _TotalRegistros = 0;

            //Ontengo la lista de un servicio relacionado a un vehiculo
            listaJuntas = await controller.CrudCaso().obtenerTodo();

            //Cantidad de registros 
            _TotalRegistros = listaJuntas.Count();

            //Divide las datos en grupos de de 10
            listaJuntas = listaJuntas.OrderByDescending(x => x.IdCaso)
                                        .Skip((pagina - 1) * RegistrosPorPagina)
                                        .Take(RegistrosPorPagina).ToList();

            //Filtro por placa o Dueno
            if (!string.IsNullOrEmpty(buscar))
            {
                //Elimino los espacios vacios de la cadena
                var lista = await controller.CrudCaso().obtenerTodo();
                var conincidencias = await controller.CrudCaso().obtenerTodo();
                //Recargo los servicios
                listaJuntas = lista.OrderBy(x => x.IdCaso)
                                    .Where(x => x.tPersona.Cedula.Contains(buscar) ||
                                    x.Consecutivo.Contains(buscar))
                                    .Skip((pagina - 1) * RegistrosPorPagina)
                                    .Take(RegistrosPorPagina).ToList();

                //Re calcula la cantidad de registros
                _TotalRegistros = conincidencias.
                                                Where(x => x.tPersona.Cedula.Contains(buscar) ||
                                                x.Consecutivo.Contains(buscar.ToUpper())).Count();
            }

            if (codigo > 0)
            {
                //Elimino los espacios vacios de la cadena
                var lista = await controller.CrudCaso().obtenerTodo();

                //Recargo los servicios
                var conincidencias = await controller.CrudCaso().obtenerTodo();
                //Recargo los servicios
                listaJuntas = lista.OrderBy(x => x.IdCaso)
                                    .Where(x => x.Codigo == codigo)
                                    .Skip((pagina - 1) * RegistrosPorPagina)
                                    .Take(RegistrosPorPagina).ToList();

                //Re calcula la cantidad de registros
                _TotalRegistros = conincidencias.Where(x => x.Codigo == codigo).Count();
            }


            if (start != null && end != null)
            {
                DateTime START = DateTime.Parse(start);
                DateTime END = DateTime.Parse(end);
                //Elimino los espacios vacios de la cadena
                var lista = await controller.CrudCaso().obtenerTodo();

                //Recargo los servicios

                var conincidencias = await controller.CrudCaso().obtenerTodo();
                //Recargo los servicios
                listaJuntas = lista.OrderBy(x => x.IdCaso)
                                    .Where(x => ((x.Fecha >= START) && (x.Fecha <= END)))
                                    .Skip((pagina - 1) * RegistrosPorPagina)
                                    .Take(RegistrosPorPagina).ToList();

                //Re calcula la cantidad de registros
                _TotalRegistros = conincidencias.
                                    Where(x => ((x.Fecha >= START) && (x.Fecha <= END))).Count();
            }
            //Calculo de las paginas
            var _TotalPaginas = (int)Math.Ceiling((double)_TotalRegistros / RegistrosPorPagina);

            paginador = new Paginador<tRevision>()
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
