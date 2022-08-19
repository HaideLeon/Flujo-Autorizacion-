using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Flujo_Autorizacion.Dominio.Modelo;
using Flujo_Autorizacion.Transversal;

namespace Flujo_Autorizacion.Dominio
{
    public class ServicioConfiguracionFlujo : IServicioConfiguracionFlujo
    {
        public Respuesta<bool> ValidarFlujo(Flujo flujo)
        {
            //Valida que el objeto no este vacio
            if (flujo == null)
                return new Respuesta<bool>("", "");

            if (flujo.tipoEntePublico == null)
                return new Respuesta<bool>("", "TAG");

            if (flujo.nivelEmpleado == null)
                return new Respuesta<bool>("", "TAG");

            if (!EsRepetido(flujo.Pasos))
                return new Respuesta<bool>("", "");

            if(!EsConsecutivo(flujo.Pasos))
                return new Respuesta<bool>("No es consecutivo", "");

            return new Respuesta<bool>(true);
        }

        public Respuesta<bool> ValidarPaso(Paso paso) {

            if(paso.orden <= 0)
                return new Respuesta<bool>("El orden debe ser mayor a 0", "");

            if (paso.rol <= 0)
                return new Respuesta<bool>("El rol debe ser mayor a 0", "");

            if (paso.tipoRol <= 0)
                return new Respuesta<bool>("El tipo rol debe ser mayor a 0", "");

            return new Respuesta<bool>(true);
        }


        private bool EsRepetido(List<Paso> paso)
        {
            return paso.GroupBy(x => x.orden).Any(g => g.Count() > 1);
        }

        private bool EsConsecutivo(List<Paso> paso) {

            int index = 1;
            var pasosOrdenados = paso.OrderBy(x => x.orden);
            foreach (var item in pasosOrdenados) 
            {
                if (item.orden != index)
                {
                    return false;
                }

                index++;
            }
            return true;
        }

     
       
    }
}
