using JewelrySalesStoreBusiness;
using JewelrySalesStoreData.Models;
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
using System.Windows.Shapes;

namespace JewelrySalesStoreWPFApp.UI
{
    /// <summary>
    /// Interaction logic for wCustomer.xaml
    /// </summary>
    public partial class wOrderDetail : Window
    {
        private readonly OrderDetailBusiness _business;
        public wOrderDetail()
        {
            InitializeComponent();
            _business = new OrderDetailBusiness();
            LoadGridOrderDetails();

        }
        private async void ButtonSave_Click(object sender, RoutedEventArgs e) { }
        private void ButtonCancel_Click(object sender, RoutedEventArgs e) { }
        private async void grdOrderDetail_ButtonDelete_Click(object sender, RoutedEventArgs e) { }
        private async void grdOrderDetail_ButtonEdit_Click(object sender, RoutedEventArgs e) { }
        
        private async void grdOrderDetail_MouseDouble_Click(object sender, RoutedEventArgs e) { }

        private async void LoadGridOrderDetails()
        {

            var result = await _business.GetAll();

            if (result.Status > 0 && result.Data != null)
            {
                gridOrderDetail.ItemsSource = result.Data as List<OrderDetail>;
            }
            else
            {
                gridOrderDetail.ItemsSource = new List<OrderDetail>();
            }

        }

    }
}
