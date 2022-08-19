using System;
using System.Collections.Generic;
using Flujo_Autorizacion.Aplicacion;
using Flujo_Autorizacion.Dominio.Modelo;

namespace Flujo_Autorizacion
{
   
    class Program 
    {
        static void Main(string[] args)
        {

            ServicioConfiguracionFlujo servicio = new ServicioConfiguracionFlujo();
            IServicioConfiguracionFlujo ServicioConfing = (IServicioConfiguracionFlujo)servicio;

            var lista = new List<Paso>();

            var obj1 = new Paso
            {
                id = 1,
                orden = 1,
                rol = 1,
                tipoRol = 2
            };
            var obj2 = new Paso
            {
                id = 2,
                orden = 2,
                rol = 2,
                tipoRol = 3
            };
            var obj3 = new Paso
            {
                id = 2,
                orden = 3,
                rol = 2,
                tipoRol = 3
            };
            var obj4 = new Paso
            {
                id = 2,
                orden = 6,
              
                tipoRol = 3
            };

            lista.Add(obj1);
            lista.Add(obj2);
            lista.Add(obj3);
            lista.Add(obj4);


            var entePublico = new ITipoEntePublico
            {
                id = 1,
                nombre = "Prueba"
            };

            var nEmpleado = new INivelEmpleado
            {
                id = 1,
                nivel = 8.2
            };

            var objFlujo = new Flujo {
                id = 2,
                tipoEntePublico = entePublico, 
                nivelEmpleado = nEmpleado,
                Pasos = lista

            };


            var respuesta = ServicioConfing.Validar(objFlujo);

            if (!respuesta.Contenido) {
                Console.WriteLine("Ocurrio un error");
            }
            else
            {
                Console.WriteLine("Todo salio correcto");
            }

        }

       

    }

  
   
}
