using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieMedii.Models
{
        public class ListPage : ContentPage
        {
            public ListPage(ShopList slist)
            {
                // Initialize the page with the provided ShopList instance
                BindingContext = slist;
            }
        }
    }

