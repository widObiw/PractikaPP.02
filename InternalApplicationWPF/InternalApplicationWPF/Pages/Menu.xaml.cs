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
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Authorization());
        }

        private void btnIntAplic_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Applic());
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new About());
        }

        private void btnReceipt_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Данная возможность станет доступна после разработки следующего модуля. Хотите продолжить в тестовом режиме?", "Expected in the near future", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    NavigationService.Navigate(new Receptor());
                    break;
            }
        }
    }
}
