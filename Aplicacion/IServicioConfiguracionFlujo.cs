using System;
using System.Collections.Generic;
using System.Text;
using Flujo_Autorizacion.Dominio.Modelo;
using Flujo_Autorizacion.Transversal;

namespace Flujo_Autorizacion.Aplicacion
{
    public interface IServicioConfiguracionFlujo
    {
        //Flujo Flujo { get; set; }

        Respuesta<bool> Validar(Flujo flujo);

    }
}
