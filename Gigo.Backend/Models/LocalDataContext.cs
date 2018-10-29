

namespace Gigo.Backend.Models
{
    using Gigo.Domain.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using Gigo.Common.Models;
    public class LocalDataContext: DataContext
    {
        public System.Data.Entity.DbSet<Product> Products { get; set; }
    }
}