using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CELEIN_webPage.Data
{
    public class CELEIN_webPageContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public CELEIN_webPageContext() : base("name=CELEIN_webPageContext")
        {
        }

        public System.Data.Entity.DbSet<CELEIN_webPage.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<CELEIN_webPage.Models.Category> Categories { get; set; }
    }
}
