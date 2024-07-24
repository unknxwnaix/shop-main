using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client
{
    public static class ProductManager
    {
        public static ObservableCollection<Product> products { get; set; }
        public static ObservableCollection<Product> displayedProducts { get; set; }

        public static decimal total { get; set; }

        static ProductManager()
        {
            products = new ObservableCollection<Product>();
            displayedProducts = new ObservableCollection<Product>();
            total = 0;
        }
    }
}
