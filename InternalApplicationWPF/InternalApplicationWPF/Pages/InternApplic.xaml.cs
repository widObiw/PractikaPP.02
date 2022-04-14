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
    /// Логика взаимодействия для InternApplic.xaml
    /// </summary>
    public partial class InternApplic : Page
    {
        public InternApplic()
        {
            InitializeComponent();
            dg.ItemsSource = DB.db.IAProduct.ToList();
            cbProd.ItemsSource = DB.db.Product.ToList();
            cbWorker.ItemsSource = DB.db.Worker.ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            int newApl = DB.db.InternalApplication.Max(c => c.IA_ID) + 1;
            int stat = 1;
            try
            {
                InternalApplication newIA = new InternalApplication()
                {
                    IA_ID = newApl,
                    Date_Start = DateTime.Now,
                    Date_End = (DateTime)dp.SelectedDate,
                    Worker_ID = (cbWorker.SelectedItem as Worker).Worker_ID,
                    Status_ID = stat
                };
                DB.db.InternalApplication.Add(newIA);
                DB.db.SaveChanges();

                MessageBox.Show("Новая заявка добавлена!", "Добавление закупки", MessageBoxButton.OK, MessageBoxImage.Information);
                tblProd.Visibility = Visibility.Visible;
                cbProd.Visibility = Visibility.Visible;
                tblAmount.Visibility = Visibility.Visible;
                tbAmount.Visibility = Visibility.Visible;
                btnIA.Visibility = Visibility.Visible;
                //NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnIA_Click(object sender, RoutedEventArgs e)
        {
            int newInter = DB.db.IAProduct.Max(h => h.IAProdict_ID) + 1;
            int newApl = DB.db.InternalApplication.Max(c => c.IA_ID);
            try
            {
                IAProduct newIAP = new IAProduct
                {
                    IAProdict_ID = newInter,
                    IA_ID = newApl,
                    Product_ID = (cbProd.SelectedItem as Product).Product_ID,
                    IAP_Amount = Convert.ToInt32(tbAmount.Text),
                };
                DB.db.IAProduct.Add(newIAP);
                DB.db.SaveChanges();
                MessageBox.Show("В заявку добавлен новый продукт!", "Добавление продукта", MessageBoxButton.OK, MessageBoxImage.Information);
                dg.ItemsSource = DB.db.IAProduct.ToList();
            }
            catch
            {

            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
