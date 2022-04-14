using InternalApplicationWPF.Classes;
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

namespace InternalApplicationWPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        int i = 0;
        int c = 2;
        public Authorization()
        {
            InitializeComponent();
        }

        private void btnAuthor_Click(object sender, RoutedEventArgs e)
        {
            string login = tbLogin.Text;
            string password = pbPassword.Password;

            try
            {
                Users user = DB.db.Users.ToList().Where(u => u.Login == login && u.Password == password).FirstOrDefault();

                if (user != null)
                {
                    MessageBox.Show("Вход выполнен успешно!","Авторизация",MessageBoxButton.OK,MessageBoxImage.Information);
                    NavigationService.Navigate(new Menu());
                }
                else if (tbLogin.Text == "" && pbPassword.Password== "")
                {
                    MessageBox.Show($@"Введите логин или пароль.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    MessageBox.Show($@"Неверный логин или пароль. Осталось попыток {c}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    c--;
                    i++;
                    if (i == 3)
                    {
                        Application.Current.Shutdown();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
