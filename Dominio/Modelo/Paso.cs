using System;
namespace Flujo_Autorizacion.Dominio.Modelo
{
    public class Paso
    {
        public int id { get; set;}

        public int orden { get; set; }

        public int rol { get; set; }

        public int tipoRol { get; set; }

        public bool esFirma { get; set; }
    }
}
