using System;
using System.Collections.Generic;
using System.Text;

namespace Flujo_Autorizacion.Aplicacion
{
    public interface IServicioFlujoAutorizacion
    {


        void Autorizar();

        void Devolver(bool esInicio=false);

        void Cancelar();

    }
}
