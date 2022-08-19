using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Flujo_Autorizacion.Dominio.Modelo;
using Flujo_Autorizacion.Transversal;
using Dominio = Flujo_Autorizacion.Dominio;

namespace Flujo_Autorizacion.Aplicacion
{
    public class ServicioConfiguracionFlujo : IServicioConfiguracionFlujo
    {

        Dominio.ServicioConfiguracionFlujo servicio = new Dominio.ServicioConfiguracionFlujo();
        Dominio.IServicioConfiguracionFlujo ServicioConfing;

        public ServicioConfiguracionFlujo() {

            ServicioConfing = servicio;
        }

        public Respuesta<bool> Validar(Flujo flujo)
        {
            if (flujo.Pasos.Count() <= 0)
                return new Respuesta<bool>("No existen pasos en este flujo", "TAG");
            
            foreach (var item in flujo.Pasos)
            {
                var respuestaPaso = ServicioConfing.ValidarPaso(item);

                if(!respuestaPaso.Contenido)
                    return new Respuesta<bool>("La información de los pasos esta incomplenta", "TAG");
            }

            var respuesta = ServicioConfing.ValidarFlujo(flujo);

            if (!respuesta.Contenido)
                return new Respuesta<bool>("La información de el flujo esta incomplenta", "TAG");

            return new Respuesta<bool> (true);
        }
    }
}
