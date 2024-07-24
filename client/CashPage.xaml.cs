using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace client
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class CashPage : Page
    {
        public CashPage()
        {
            InitializeComponent();

            productGrid.ItemsSource = ProductManager.displayedProducts;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.Button button = sender as System.Windows.Controls.Button;
            if (button != null)
            {
                Product product = button.DataContext as Product;
                if (product != null)
                {
                    ProductManager.displayedProducts.Remove(product);
                }
            }
        }

        private void payBtn_Click(object sender, RoutedEventArgs e)
        {
            if (payMethodCb.SelectedIndex == 0)
            {
                PaymentWindow paymentWindow = new PaymentWindow();
                paymentWindow.Show();
            }
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            AddProduct(barcodeTb.Text);
        }

        private void barcodeTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Проверяем, что вводимый текст является цифрой
            e.Handled = !IsTextAllowed(e.Text);
        }

        private static readonly Regex _regex = new Regex("[^0-9]"); // Регулярное выражение для нецифровых символов

        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text) && text.All(c => c != ' ');
        }

        private void AddProduct(string barcode)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(barcode))
                {
                    MessageBox.Show("Пустой штрих-код");
                    return;
                }

                MessageBox.Show($"Ищем продукт с штрих-кодом: {barcode}");
                var product = ProductManager.products.FirstOrDefault(p => p.Barcode == barcode);
                if (product != null)
                {
                    // Поиск в отображаемой коллекции
                    var displayedProduct = ProductManager.displayedProducts.FirstOrDefault(p => p.Barcode == barcode);
                    if (displayedProduct != null)
                    {
                        // Если продукт уже есть, увеличиваем его количество
                        displayedProduct.Quantity++;
                        // Обновляем отображение DataGrid
                        productGrid.Items.Refresh();
                    }
                    else
                    {
                        // Если продукта нет в отображаемой коллекции, добавляем его
                        product.Quantity = 1; // Устанавливаем начальное количество
                        ProductManager.displayedProducts.Add(product);
                    }

                    // Обновление итоговой суммы
                    UpdateTotal();
                    MessageBox.Show($"Продукт добавлен: {product.Name}");
                }
                else
                {
                    MessageBox.Show("Продукт не найден");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сканировании: {ex.Message}");
            }
        }

        private void UpdateTotal()
        {
            try
            {
                ProductManager.total = 0;
                foreach (Product product in ProductManager.displayedProducts)
                {
                    ProductManager.total += product.Retail_Price * product.Quantity;
                }

                // Используем правильное форматирование валюты
                resultTb.Text = $"Итог: {ProductManager.total:F2} ₽";
                MessageBox.Show($"Обновленная итоговая сумма: {ProductManager.total:F2} ₽");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении итоговой суммы: {ex.Message}");
            }
        }
    }
}
