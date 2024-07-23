using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace client
{
    /// <summary>
    /// Логика взаимодействия для PaymentWindow.xaml
    /// </summary>
    public partial class PaymentWindow : Window
    {

        public int sum = 5000;
        public PaymentWindow()
        {
            InitializeComponent();
            bill.Text = $"К оплате: {sum.ToString()}";
        }

        private void finishBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(pay.Text) >= sum)
            {
                change.Text = $"Сдача: {(Convert.ToInt32(pay.Text) - sum).ToString()}";
            }
            else
            {
                MessageBox.Show("не хватает");
            }
        }
    }
}
