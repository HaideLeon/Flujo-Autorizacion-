using System;
using System.Collections.Generic;

namespace Flujo_Autorizacion.Dominio.Modelo
{
    public class Flujo
    {
        public int id { get; set; }

        //public int tipoEntePublico{ get; set; }

        public ITipoEntePublico tipoEntePublico { get; set; }

        public INivelEmpleado nivelEmpleado { get; set; }

        //public double nivelEmpleado { get; set; }
         
        public List<Paso> Pasos { get; set; }
    }
}
