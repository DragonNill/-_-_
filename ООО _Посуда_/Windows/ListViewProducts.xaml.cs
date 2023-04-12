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
using ООО__Посуда_.Model.Enity;
using ООО__Посуда_.UserControls;

namespace ООО__Посуда_.Windows
{
    /// <summary>
    /// Логика взаимодействия для ListViewProducts.xaml
    /// </summary>
    public partial class ListViewProducts : Window
    {
        User currentUser;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="user"></param>
        public ListViewProducts(User user)
        {
            InitializeComponent();
            currentUser = user;

            if (currentUser != null)
            {
                SNPLabel.Content = $"{currentUser.UserSurname} {currentUser.UserName}";
            }
            else
            {
                SNPLabel.Content = $"Гость";
            }

            FillComboBox();
            FillListView();
        }


        /// <summary>
        /// Метод для заполнения выпадающих списков
        /// </summary>
        private void FillComboBox()
        {
            FilterComboBox.SelectedIndex = 0;
            FilterComboBox.Items.Add("Все производители");

            foreach(string nameManufacturer in tradeContext.DbContext.Manafacturers.Select(f => f.ManafacturerName).ToList())
            {
                FilterComboBox.Items.Add(nameManufacturer);
            }

            SortingComboBox.SelectedIndex = 0;
            SortingComboBox.Items.Add("Без сортирвовки");
            SortingComboBox.Items.Add("Стоимость ↑");
            SortingComboBox.Items.Add("Стоимость ↓");
        }

        /// <summary>
        /// Метод для заполнения ListView
        /// </summary>
        private void FillListView()
        {
            ProductsListView.Items.Clear();


            List<Product> productsList = tradeContext.DbContext.Products.ToList();

            // Поиск
            if(!string.IsNullOrWhiteSpace(FindTextBox.Text))
            {
                productsList = productsList.Where(f => f.ProductName.ToLower().Contains(FindTextBox.Text.ToLower()) 
                || f.ProductManufacturer.ManafacturerName.ToLower().Contains(FindTextBox.Text.ToLower())
                || f.ProductDescription.ToLower().Contains(FindTextBox.Text.ToLower())
                || f.ProductCost.ToString().ToLower().Contains(FindTextBox.Text)
                || f.ProductQuantityInStock.ToString().ToLower().Contains(FindTextBox.Text.ToLower())).ToList();
            }

            //Фильтрация
            switch (FilterComboBox.SelectedIndex)
            {
                case 0:
                    break;
                default:
                    productsList = productsList.Where(f => f.ProductManufacturerId == FilterComboBox.SelectedIndex).ToList();
                    break;
            }

            //Сортировка
            switch (SortingComboBox.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    productsList = productsList.OrderBy(s => s.ProductCost).ToList();
                    break;
                case 2:
                    productsList = productsList.OrderByDescending(s => s.ProductCost).ToList();
                    break;
            }


            foreach(Product product in productsList)
            {
                ProductsListView.Items.Add(new ProductControl(product)
                {
                    Width = GetOptimized()
                });
            }

            CountProductsLabel.Content = $"Товаров на странице: {productsList.Count}";

            if(productsList.Count == 0)
            {
                MessageBox.Show("По вашему запросу товаров не найдено", "Уведмоление",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }


        }

        private double GetOptimized()
        {
            if (WindowState == WindowState.Maximized)
            {
                return RenderSize.Width - 55;
            }
            else
            {
                return Width - 55;
            }
            
        }


        /// <summary>
        /// Событие
        /// </summary>
        /// <param name="sender">Обьект вызвающий событие</param>
        /// <param name="e">Аргумент события</param>
        private void FindTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            FillListView();
        }

        private void FilterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FillListView();
        }

        private void SortingComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FillListView();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            FillListView();
        }
    }
}
