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
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace InternalApplicationWPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для Applic.xaml
    /// </summary>
    public partial class Applic : Page
    {
        public Applic()
        {
            InitializeComponent();
            dg.ItemsSource = DB.db.IAProduct.ToList();
            cbIAID.ItemsSource = DB.db.InternalApplication.ToList();
        }

        

        private void btnAplic_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new InternApplic());
        }

        private void btnWord_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Hапечатать в формате .DOCX?", "", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            switch (result)
            {
                case MessageBoxResult.OK:
                    //Microsoft.Office.Interop.Word.Document doc = null;
                    Microsoft.Office.Interop.Word.Application app = new Word.Application();
                    var zayavka = dg.SelectedItem as InternalApplication;
                    try
                    {
                        //string src = $@"{Directory.GetCurrentDirectory()}\Docs\word.docx";
                        //doc = app.Documents.Open(src);
                        //doc.Activate();

                        //Word.Bookmarks wBM = doc.Bookmarks;

                        //wBM["ZayavkaNo"].Range.Text = zayavka.IA_ID.ToString();
                        //wBM["Data"].Range.Text = zayavka.Date_Start.ToString();

                        //Word.Table table = doc.Tables[1];

                        //int row = 1;

                        //foreach (IAProduct p in zayavka.IAProduct.ToList())
                        //{
                        //    table.Rows.Add();
                        //    row++;

                        //    table.Cell(row, 1).Range.Text = $"{p.IAProdict_ID}";
                        //    table.Cell(row, 2).Range.Text = $"{p.Product.Product_Name}";
                        //    table.Cell(row, 3).Range.Text = $"{p.IAP_Amount}";
                        //    table.Cell(row, 4).Range.Text = $"{p.Product.Unit.Unit_Name}";
                        //}

                        //string savePath = $@"{Directory.GetCurrentDirectory()}\Docs";


                        //if (!Directory.Exists(savePath))
                        //    Directory.CreateDirectory(savePath);

                        //doc.SaveAs2($@"{savePath}\{zayavka.IA_ID.ToString()}.docx", Word.WdSaveFormat.wdFormatPDF);

                        MessageBox.Show("Заявка сформирована","Word",MessageBoxButton.OK,MessageBoxImage.Information);
                        dg.ItemsSource = DB.db.IAProduct.ToList();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        //doc.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
                        //doc = null;
                        //app.Quit(Word.WdSaveOptions.wdDoNotSaveChanges);
                    }
                    break;
            }
        }
        private void btnExcel_Click(object sender, RoutedEventArgs e)
        {
            //создаем выгрузку в CSV
            IAProduct IAP = dg.SelectedItem as IAProduct;
            Excel.Application app = null;
            try
            {
                app = new Excel.Application();
                app.Workbooks.Add(Type.Missing);
                Excel.Workbook wB;
                wB = app.Workbooks.Add();
                Excel.Worksheet wS = (Excel.Worksheet)app.Sheets[1];
                wS = (Excel.Worksheet)wB.Worksheets.get_Item(1);
                //создаем заголовки в документе
                wS.Cells[1, 1] = "Заявка №";
                wS.Cells[2, 1] = "Дата:";
                wS.Cells[4, 1] = "№ п/п";
                wS.Cells[4, 2] = "Наименование";
                wS.Cells[4, 3] = "Количество";
                wS.Cells[4, 4] = "Единица измерения";
                wS.Cells[4, 5] = "Примечание";
                //выгружвем данные в таблицу
                DB.db.IAProduct.Where(x => x.IAProdict_ID == IAP.IAProdict_ID).FirstOrDefault();
                wS.Cells[1, 2] = IAP.IAProdict_ID;
                wS.Cells[2, 2] = IAP.InternalApplication.Date_Start;
                wS.Cells[5, 1] = IAP.IAProdict_ID;
                wS.Cells[5, 2] = IAP.Product.Product_Name;
                wS.Cells[5, 3] = IAP.IAP_Amount;
                wS.Cells[5, 4] = IAP.Product.Unit.Unit_Name;
            }
            catch (Exception)
            {

            }
            //сохраняем результат
            MessageBoxResult result = MessageBox.Show("Hапечатать в формате .xlsx?", "", MessageBoxButton.YesNo, MessageBoxImage.Question);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    app.Application.ActiveWorkbook.SaveAs($@"{Directory.GetCurrentDirectory()}\Docs\Заявка № {IAP.InternalApplication.IA_ID}.xlsx");
                    MessageBox.Show("Заявка .XLSX сформирована", "Ecxel", MessageBoxButton.OK, MessageBoxImage.Information);
                    dg.ItemsSource = DB.db.IAProduct.ToList();
                    app.Quit();
                    break;
                case MessageBoxResult.No:
                    MessageBoxResult result1 = MessageBox.Show("Hапечатать в формате .csv?", "", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    switch (result1)
                    {
                        case MessageBoxResult.Yes:
                            app.Application.ActiveWorkbook.SaveAs($@"{Directory.GetCurrentDirectory()}\Docs\Заявка № {IAP.InternalApplication.IA_ID}.xlsx");
                            MessageBox.Show("Спецификация .CSV сформирована", "CSV", MessageBoxButton.OK, MessageBoxImage.Information);
                            dg.ItemsSource = DB.db.IAProduct.ToList();
                            app.Quit();
                            break;
                    }
                    break;        
            }
            
        }

        private void rbtnDateStart_Checked(object sender, RoutedEventArgs e)
        {
            var IA = dg.ItemsSource as List<IAProduct>;
            for (int i = 0; i < IA.Count; i++)
            {
                for (int j = 0; j < IA.Count; j++)
                    if (IA[i].InternalApplication.Date_Start > IA[j].InternalApplication.Date_Start)
                    {
                        // Обмен значениями
                        var z = IA[i];
                        IA[i] = IA[j];
                        IA[j] = z;
                    }
            }
            dg.ItemsSource = null;
            dg.ItemsSource = IA;
        }

        private void rbtnDateEnd_Checked(object sender, RoutedEventArgs e)
        {
            var IA = dg.ItemsSource as List<IAProduct>;
            for (int i = 0; i < IA.Count; i++)
            {
                for (int j = 0; j < IA.Count; j++)
                    if (IA[i].InternalApplication.Date_End < IA[j].InternalApplication.Date_End)
                    {
                        // Обмен значениями
                        var z = IA[i];
                        IA[i] = IA[j];
                        IA[j] = z;
                    }
            }
            dg.ItemsSource = null;
            dg.ItemsSource = IA;
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Menu());
        }
        private void cbIAID_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int num = Convert.ToInt32(cbIAID.SelectedValue);
            dg.ItemsSource = DB.db.IAProduct.Where(x => x.IA_ID == num).ToList();
        }
    }
}
