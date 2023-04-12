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

namespace ООО__Посуда_.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddOrUpdateProduct.xaml
    /// </summary>
    public partial class AddOrUpdateProduct : Window
    {

        Product currentProduct;

        public AddOrUpdateProduct(Product currentProduct)
        {
            InitializeComponent();
            this.currentProduct = currentProduct;

            FillComboBoxes();
        }

        private void FillComboBoxes()
        {
            UnitComboBox.SelectedIndex = 0;
            CategoryComboBox.SelectedIndex = 0;
            SupplierComboBox.SelectedIndex = 0;
            ManafacturerComboBox.SelectedIndex = 0;
            
            foreach(string unit in tradeContext.DbContext.Units.Select(u => u.UnitName).ToList())
            {
                UnitComboBox.Items.Add(unit);
            }

            foreach(string category in tradeContext.DbContext.Categories.Select(u => u.CategoryName).ToList())
            {
                CategoryComboBox.Items.Add(category);
            }

            foreach(string suppplier in tradeContext.DbContext.Suppliers.Select(s => s.SupplierName).ToList())
            {
                SupplierComboBox.Items.Add(suppplier);
            }

            foreach(string manafacturer in tradeContext.DbContext.Manafacturers.Select(s => s.ManafacturerName).ToList())
            {
                ManafacturerComboBox.Items.Add(manafacturer);
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (currentProduct != null)
            {
                Title = "Редактирвование";

                AddOrUpdateLabel.Content = "Редактирвование";

                AddOrUpdateButton.Content = "Редактировать";

                ArticleNumberTextBox.Text = currentProduct.ProductArticleNumber;
                NameTextBox.Text = currentProduct.ProductName;
                UnitComboBox.SelectedIndex = currentProduct.ProductUnitId;
                CategoryComboBox.SelectedIndex = currentProduct.ProductCategoryId;
                ManafacturerComboBox.SelectedIndex = currentProduct.ProductManufacturerId;
                CostTextBox.Text = currentProduct.ProductCost.ToString();
                DescriptionTextBox.Text = currentProduct.ProductDescription.ToString();
                CountInStackTextBox.Text = currentProduct.ProductQuantityInStock.ToString();
                DiscountMaxTextBox.Text = currentProduct.ProductDiscountMax.ToString();
                DiscountAmountTextBox.Text = currentProduct.ProductDiscountAmount.ToString();
                SupplierComboBox.SelectedIndex = currentProduct.ProductSupplierId;

                if (currentProduct.ProductPhoto != null && currentProduct.ProductPhoto.Length > 0)
                {
                    ImageProduct.Source = new BitmapImage(new Uri(System.IO.Path.Combine(Environment.CurrentDirectory,
                        "Images/", currentProduct.ProductPhoto), UriKind.Absolute));
                }
                else
                {
                    ImageProduct.Source = new BitmapImage(new Uri(System.IO.Path.Combine(Environment.CurrentDirectory,
                        "Images/picture.png"), UriKind.Absolute));
                }
            }
            
        }

        private void AddOrUpdateButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
