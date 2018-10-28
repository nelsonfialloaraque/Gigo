using Gigo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Gigo.Common.Models;
using Gigo.ViewModels;

namespace TestConsole
{
    class Program: BaseViewModel
    {
        private ApiService apiservice;
        
                      
       
    

        public Program()
        {
            apiservice = new ApiService();
            this.LoadProducts();
        }

        private async void LoadProducts()
        {
            var response = await this.apiservice.GetList<Product>("https://gigoapiservices.azurewebsites.net", "/api", "/Products");
            if (!response.IsSuccess)
            {
                //await Application.Current.MainPage.DisplayAlert("Error", response.Message, "Accept");

                Console.WriteLine("im failed");
            }

            // if we arrive here, we could have the list of products Json  but we have to convert to List<Product> of ObservableCollection
            // take the list we passe this instance observableCollection
            var list = (List<Product>)response.Result;
          //  this.Products = new ObservableCollection<Product>(list);
        }


        static void Main(string[] args)
            {

                Console.WriteLine("Test************");
               

            Program programa = new Program();
            
            Console.Read();
        }
    }

    
    
}
