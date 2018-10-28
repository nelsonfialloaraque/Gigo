using Gigo.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gigo.Infrastructure
{
   public class InstanceLocator
    {

        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
