

namespace Gigo.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Gigo.Common.Models;
    public class DataContext:DbContext
    {

        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Product> Products { get; set; }
    }
}
