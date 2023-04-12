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
using ООО__Посуда_.Windows;
using System.Threading;

namespace ООО__Посуда_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(LoginTextBox.Text) && !string.IsNullOrWhiteSpace(PassPasswordBox.Password))
            {
                User user = tradeContext.DbContext.Users.Where(u => u.UserLogin == LoginTextBox.Text
                && u.UserPassword == PassPasswordBox.Password).FirstOrDefault();

                if(user != null)
                {
                    Window nextWindow = new ListViewProducts(user);
                    Hide();
                    MessageBox.Show($"Добро пожаловать {user.UserSurname} {user.UserName} {user.UserPatronymic}\n" +
                        $"Вы успешно авторизовались как {user.UserRole.RoleName}","Уведомление",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                    nextWindow.ShowDialog();
                    Show();
                }
                else if (i == 5)
                {
                    i = 0;
                    MessageBox.Show("Вы превысили число попыток\nПодождите 10 сек", "Предупреждение",
                        MessageBoxButton.OK, MessageBoxImage.Warning);
                    Title = "Блокировка";
                    Thread.Sleep(10 * 1000);
                }
                else
                {
                    i++;

                    MessageBox.Show("Такого пользователя не существует", "Предупреждение",
                        MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
               if (i == 5)
                {
                    i = 0;
                    MessageBox.Show("Вы превысили число попыток\nПодождите 10 сек","Предупреждение",
                        MessageBoxButton.OK,MessageBoxImage.Warning);
                    Title = "Блокировка";
                    Thread.Sleep(10 * 1000);
                }
                else
                {
                    i++;

                    MessageBox.Show("Все поля должны быть заполнены", "Предупреждение",
                        MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        private void LoginAsGuessButton_Click(object sender, RoutedEventArgs e)
        {
            Window nextWindow = new ListViewProducts(null);
            Hide();
            MessageBox.Show($"Добро пожаловать ", "Предупреждение",
                MessageBoxButton.OK, MessageBoxImage.Warning);
            nextWindow.ShowDialog();
            Close();
        }
    }
}
