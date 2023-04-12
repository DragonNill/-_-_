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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ООО__Посуда_.Model.Enity;

namespace ООО__Посуда_.UserControls
{
    /// <summary>
    /// Логика взаимодействия для ProductControl.xaml
    /// </summary>
    public partial class ProductControl : UserControl
    {
        Product currentProduct;

        public ProductControl(Product currentProduct)
        {
            InitializeComponent();
            this.currentProduct = currentProduct;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            LoadLabels();
            LoadImage();
        }

        private void LoadLabels()
        {
            NameProductLabel.Content = currentProduct.ProductName;
            DescriptionProductLabel.Content = $"Описание товара: {currentProduct.ProductDescription}";
            ManufacturerProductLabel.Content = $"Производитель: {currentProduct.ProductManufacturer.ManafacturerName}";
            CountInStack.Content = $"Наличие на складе: {currentProduct.ProductQuantityInStock}";
            CostProductLabel.Content = $"Цена товара: {currentProduct.ProductCost} руб.";

            if(currentProduct.ProductQuantityInStock <= 0)
            {
                Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void LoadImage()
        {
            if (currentProduct.ProductPhoto != null && currentProduct.ProductPhoto.Length > 0)
            {
                ProductImage.Source = new BitmapImage(new Uri(System.IO.Path.Combine(Environment.CurrentDirectory,
                    "Images/",currentProduct.ProductPhoto),UriKind.Absolute));
            }
            else
            {
                ProductImage.Source = new BitmapImage(new Uri(System.IO.Path.Combine(Environment.CurrentDirectory,
                    "Images/picture.png"), UriKind.Absolute));
            }
        }
    }
}
