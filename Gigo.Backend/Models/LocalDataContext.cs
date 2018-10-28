

namespace Gigo.Backend.Models
{
    using Gigo.Domain.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    public class LocalDataContext: DataContext
    {
        public System.Data.Entity.DbSet<Gigo.Common.Models.Product> Products { get; set; }
    }
}