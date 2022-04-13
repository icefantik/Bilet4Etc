using System;
using System.Collections.Generic;
using System.Data;
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

namespace ExamBilet
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Database database = new Database();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickBackorders(object sender, RoutedEventArgs e)
        {
            table.ItemsSource = Database.GetListOrderFurnt();
        }

        private void ClickOpenSumRequests(object sender, RoutedEventArgs e)
        {
            SumRequestsPlanDates sumRequestsPlanDates = new SumRequestsPlanDates();
            sumRequestsPlanDates.Show();
        }
    }
}
