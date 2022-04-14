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
    /// Логика взаимодействия для ReceptorEdit.xaml
    /// </summary>
    public partial class ReceptorEdit : Page
    {
        public Product prod;
        bool Change = true;
        public ReceptorEdit()
        {
            InitializeComponent();
            Change = false;
            cbEd.ItemsSource = DB.db.Unit.ToList();
        }

        public ReceptorEdit(Product _prod)
        {

            InitializeComponent();
            Change = true;
            cbEd.ItemsSource = DB.db.Unit.ToList();
            cbEd.SelectedItem = _prod.Unit;
            this.prod = _prod;
            tbName.Text = _prod.Product_Name.ToString();
            cbEd.SelectedItem = _prod.Unit.Unit_Name.ToString();
            tbShelf.Text = _prod.Shelf_Life.ToString();
        }

        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {
            int newProd = DB.db.Product.Max(h => h.Product_ID) + 1;
            if (!Change)
            {
                try
                {
                    Product newProducts = new Product
                    {
                        Product_ID = newProd,
                        Product_Name = tbName.Text,
                        Unit_ID = (cbEd.SelectedItem as Unit).Unit_ID,
                        Shelf_Life = tbShelf.Text
                    };
                    DB.db.Product.Add(newProducts);
                    DB.db.SaveChanges();
                    MessageBox.Show("Новый продукт добавлен!", "Добавление продукта", MessageBoxButton.OK, MessageBoxImage.Information);
                    NavigationService.GoBack();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    prod.Product_Name = tbName.Text;
                    prod.Unit_ID = (int)cbEd.SelectedValue;
                    prod.Shelf_Life = tbShelf.Text;
                    DB.db.SaveChanges();
                    MessageBox.Show("Продукция изменена!", "Изменение продукции", MessageBoxButton.OK, MessageBoxImage.Information);
                    NavigationService.GoBack();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnCanc_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void tbName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Char.IsNumber(e.Text, 0))
                e.Handled = true;
        }
    }
}
