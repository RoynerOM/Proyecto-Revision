﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Interfaces;

namespace Negocios
{
    //Plantilla
    public class InstitucionNegocio : ICrud<t_Institucion>
    {
        public bool eliminar(t_Institucion e)
        {
            throw new NotImplementedException();
        }

        public bool guardar(t_Institucion e)
        {
            throw new NotImplementedException();
        }

        public bool modificar(t_Institucion e)
        {
            throw new NotImplementedException();
        }

        public t_Institucion obtenerPorId(t_Institucion e)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<t_Institucion> obtenerTodo(t_Institucion e)
        {
            throw new NotImplementedException();
        }
    }
}
