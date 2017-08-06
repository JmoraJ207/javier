using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio
{
    public class Productos
    {

        static Modelo.AdventureWorks2014Entities _Contexto = new Modelo.AdventureWorks2014Entities();
        public Productos()
        {
        }

        public Modelo.Product EncontrarProductoPorNumero(string elNumero)
        {
            Modelo.Product elProducto = new Modelo.Product();
            elProducto = _Contexto.Product.Include("ProductSubCategory").Include("ProductModel").Include(" ProductReview").Include("ProductSubCategory.ProductCategory").Where(p => p.ProductNumber.Equals(elNumero)).FirstOrDefault();
            return elProducto;
        }

       public IList<Modelo.Product> BuscarProductoPorRangoDePrecio(decimal elPrecioInferior, decimal elPrecioSuperior)
        {
             var losProductos = _Contexto.Product.Where(p => elPrecioInferior <= p.ListPrice && p.ListPrice <= elPrecioSuperior).ToList();
            return losProductos;
        }
    }
}