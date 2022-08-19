using System;
using System.Collections.Generic;
using System.Text;
using Flujo_Autorizacion.Dominio.Modelo;
using Flujo_Autorizacion.Transversal;

namespace Flujo_Autorizacion.Dominio
{
    public interface IServicioConfiguracionFlujo
    {
        Respuesta<bool> ValidarFlujo(Flujo flujo);

        Respuesta<bool> ValidarPaso(Paso paso);
    }
}
