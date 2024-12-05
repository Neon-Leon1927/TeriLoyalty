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

namespace TeriLoyalty
{
    /// <summary>
    /// Логика взаимодействия для EditLoyalAppWindow.xaml
    /// </summary>
    public partial class EditLoyalAppWindow : Window
    {
        public EditLoyalAppWindow()
        {
            InitializeComponent();
            EditLoyalAppFrame.Navigate(new EditPage());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.AdminFrame.GoBack();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DataBase.CloseConnection();
        }
    }
}
