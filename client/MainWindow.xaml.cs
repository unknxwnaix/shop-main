using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Text;

namespace client
{
    //пидорасы гнили
    public partial class MainWindow : Window
    {
        private ObservableCollection<Product> products = new ObservableCollection<Product>();
        private ObservableCollection<Product> displayedProducts = new ObservableCollection<Product>();
        private StringBuilder inputBuffer = new StringBuilder();

        public MainWindow()
        {
            InitializeComponent();
            productGrid.ItemsSource = displayedProducts; // Устанавливаем ItemsSource для DataGrid
            LoadProducts();
        }

        private async void LoadProducts()
        {
            try
            {
                // Замените URL на URL вашего API
                string apiUrl = "http://127.0.0.1:8000/api/products/";
                var productList = await ApiHelper.GetProductsAsync(apiUrl);

                foreach (var product in productList)
                {
                    products.Add(product);
                }

                MessageBox.Show("Продукты успешно загружены");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            // Перехватываем нажатие клавиш
            if (e.Key == Key.Enter)
            {
                // Если нажат Enter, это может быть результат сканирования
                string barcode = inputBuffer.ToString();
                OnBarcodeScanned(barcode);
                inputBuffer.Clear(); // Очищаем буфер после обработки
            }
            else
            {
                // Добавляем нажатую клавишу в буфер
                inputBuffer.Append((char)KeyInterop.VirtualKeyFromKey(e.Key));
            }

            e.Handled = true; // Устанавливаем обработано, чтобы избежать дальнейшего распространения события
        }

        private void OnBarcodeScanned(string barcode)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(barcode))
                {
                    MessageBox.Show("Пустой штрих-код");
                    return;
                }

                MessageBox.Show($"Ищем продукт с штрих-кодом: {barcode}");
                var product = products.FirstOrDefault(p => p.Barcode == barcode);
                if (product != null)
                {
                    // Поиск в отображаемой коллекции
                    var displayedProduct = displayedProducts.FirstOrDefault(p => p.Barcode == barcode);
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
                        displayedProducts.Add(product);
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
                decimal total = 0;
                foreach (Product product in displayedProducts)
                {
                    total += product.Retail_Price * product.Quantity;
                }

                // Используем правильное форматирование валюты
                resultTb.Text = $"Итог: {total:F2} ₽";
                MessageBox.Show($"Обновленная итоговая сумма: {total:F2} ₽");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении итоговой суммы: {ex.Message}");
            }
        }
    }
}
