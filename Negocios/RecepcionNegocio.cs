﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Interfaces;
using Datos;

namespace Negocios
{
   public class RecepcionNegocio : ICrud<t_Recepcion>
    {
        RecepcionDatos datos = new RecepcionDatos();
        public bool eliminar(t_Recepcion e)
        {
            throw new NotImplementedException();
        }

        public bool guardar(t_Recepcion e)
        {
            throw new NotImplementedException();
        }

        public bool modificar(t_Recepcion e)
        {
            throw new NotImplementedException();
        }

        public t_Recepcion obtenerPorId(t_Recepcion e)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<t_Recepcion> obtenerTodo(t_Recepcion e)
        {
            return datos.obtenerTodo(e);
        }
    }
}
