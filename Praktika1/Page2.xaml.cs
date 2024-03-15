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
using Praktika1.DataSetTableAdapters;

namespace Praktika1
{
    public partial class Page2 : Page
    {
        OrdersTableAdapter orders = new OrdersTableAdapter();

        public Page2()
        {
            InitializeComponent();

            DataGrid2.ItemsSource = orders.GetData();
        }

        private void ButtonPage2_Right_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page3());
        }

        private void ButtonPage2_Left_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }
    }
}
