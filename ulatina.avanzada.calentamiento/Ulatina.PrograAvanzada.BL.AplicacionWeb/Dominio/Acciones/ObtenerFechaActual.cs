using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.PrograAvanzada.BL.AplicacionWeb.Dominio.Acciones
{
    public class ObtenerFechaActual
    {

        public string ObtengaLaFecha() {

            var laEspecificacion = new Especificaciones.ObtenerFecha();

          var laFecha = laEspecificacion.FormatearUnaFecha(DateTime.Now,"dd/mm/yyyy");

            return laFecha; 
        }

    }
}