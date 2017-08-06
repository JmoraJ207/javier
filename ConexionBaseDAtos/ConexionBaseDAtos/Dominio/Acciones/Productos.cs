using System;
using System.Collections.Generic;

namespace ConexionBaseDAtos.Acciones
{
    public class Productos
    {
        public Productos()
        {
        }

        public Modelo.Product EncontrarProductoPorNumero(string elNumero)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var elProducto = laEspecificacion.EncontrarProductoPorNumero(elNumero);
            return elProducto;
        }

        public IList<Modelo.Product> BuscarProductoPorRangoDePrecio(decimal elPrecioInferior, decimal elPrecioSuperior)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var losProductos = laEspecificacion.BuscarProductoPorRangoDePrecio(elPrecioInferior, elPrecioSuperior);
            return losProductos;
        }
    }
}