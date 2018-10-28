using System;
using System.Collections.Generic;
using System.Text;

namespace Gigo.ViewModels
{
   public class MainViewModel
    {

        public ProductsViewModel Products { get; set; }

        public MainViewModel()
        {
            this.Products = new ProductsViewModel();
        }
    }
}
