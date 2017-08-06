using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    
        public class AdventureWorks2014EntitiesContext : DbContext
        {
            // You can add custom code to this file. Changes will not be overwritten.
            // 
            // If you want Entity Framework to drop and regenerate your database
            // automatically whenever you change your model schema, please use data migrations.
            // For more information refer to the documentation:
            // http://msdn.microsoft.com/en-us/data/jj591621.aspx

            public AdventureWorks2014EntitiesContext() : base("name=AdventureWorks2014EntitiesContext")
            {
            }

            public System.Data.Entity.DbSet<Modelo.Product> Products { get; set; }

            public System.Data.Entity.DbSet<Modelo.ProductModel> ProductModels { get; set; }

            public System.Data.Entity.DbSet<Modelo.ProductSubcategory> ProductSubcategories { get; set; }
        }

    }
