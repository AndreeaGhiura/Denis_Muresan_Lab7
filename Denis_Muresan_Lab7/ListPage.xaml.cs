using AplicatieMedii;
using AplicatieMedii.Models;

namespace AplicatieMedii
{
    public partial class ListPage : ContentPage
    {
        ShopList sl;
        public ListPage(ShopList slist)
        {
            InitializeComponent();
            sl = slist;

        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var slist = (ShopList)BindingContext;
            slist.Date = DateTime.UtcNow;
            await App.Database.SaveShopListAsync(slist);
            await Navigation.PopAsync();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var slist = (ShopList)BindingContext;
            await App.Database.DeleteShopListAsync(slist);
            await Navigation.PopAsync();
        }
        async void OnChooseButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(page: new ProductPage((ShopList)
           this.BindingContext)
            {
                BindingContext = new Product()
            });

        }

    }
}