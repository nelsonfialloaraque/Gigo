

namespace Gigo.ViewModels
{

    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Windows.Input;
    using Common.Models;
    
    using Services;
    using Xamarin.Forms;
    public  class ProductsViewModel:BaseViewModel
    {
        private ApiService apiService;
        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Productos
        {

            get { return this.products; }


            set { this.SetValue(ref this.products, value); }
        }

        public ProductsViewModel()
        {
            apiService = new ApiService();
            this.LoadProducts();
        }

        private async void LoadProducts()
         {
             var response = await this.apiService.GetList<Product>("https://gigoapiservices.azurewebsites.net", "/api","/Products");
             if (!response.IsSuccess)
             {
                 await Application.Current.MainPage.DisplayAlert("Error",response.Message, "Accept");
                 return; 
             }

             // if we arrive here, we could have the list of products Json  but we have to convert to List<Product> of ObservableCollection
             // take the list we passe this instance observableCollection
              var list = (List<Product>)response.Result;
             //List<Product> list = new List<Product>();
             this.Productos = new ObservableCollection<Product>(list);
         }

       





    }
}
