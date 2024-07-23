using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static MaterialDesignThemes.Wpf.Theme;

namespace client
{
    public partial class CashierWindow : Window
    {
        public CashierWindow()
        {
            InitializeComponent();

            List<Person> people = new List<Person>
                {
                    new Person { Name = "Alice", Age = 25 },
                    new Person { Name = "Bob", Age = 30 },
                    new Person { Name = "Charlie", Age = 35 }
                };
            cashFrame.Content = new CashPage();
            //productGrid.ItemsSource = people;

        }

        /*private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.Button button = sender as System.Windows.Controls.Button;
            if (button != null)
            {
                Person person = button.DataContext as Person;
                if (person != null)
                {
                    List<Person> people = productGrid.ItemsSource as List<Person>;
                    if (people != null)
                    {
                        people.Remove(person);
                        productGrid.ItemsSource = null;
                        productGrid.ItemsSource = people;
                    }
                }
            }
        }*/
    }
}
