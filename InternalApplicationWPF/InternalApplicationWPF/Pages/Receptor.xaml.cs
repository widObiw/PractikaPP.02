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
    /// Логика взаимодействия для Receptor.xaml
    /// </summary>
    public partial class Receptor : Page
    {
        public Receptor()
        {
            InitializeComponent();
            dg.ItemsSource = DB.db.Product.ToList();
        }

        private void TbSerch_TextChanged(object sender, TextChangedEventArgs e)
        {
            var nm = DB.db.Product.ToList();

            for (int i = 0; i < nm.Count; i++)
            {
                if (!nm[i].Product_Name.ToLower().Contains(tbSerch.Text.ToLower()))
                {
                    nm.RemoveAt(i);
                    i--;
                }

                dg.ItemsSource = nm;
            }

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ReceptorEdit());
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ReceptorEdit(dg.SelectedItem as Product));
            dg.ItemsSource = DB.db.Product.ToList();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            Product delProd = dg.SelectedItem as Product;

            MessageBoxResult result = MessageBox.Show("Вы точно хотите удалить продукт?", "Удаление продукции", MessageBoxButton.YesNo, MessageBoxImage.Question);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    DB.db.Product.Remove(delProd);
                    DB.db.SaveChanges();
                    break;
                case MessageBoxResult.No:
                    break;
            }
            dg.ItemsSource = DB.db.Product.ToList();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            dg.ItemsSource = DB.db.Product.ToList();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Menu());
        }
    }
}
