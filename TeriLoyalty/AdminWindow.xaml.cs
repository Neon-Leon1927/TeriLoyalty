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
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
            Manager.AdminFrame = AdminFrame;
        }

        private void EditLoyalApp_Click(object sender, RoutedEventArgs e)
        {
            EditLoyalAppWindow editLoyalAppWindow = new EditLoyalAppWindow();
            editLoyalAppWindow.ShowDialog();
        }

        private void BtnBonus_Click(object sender, RoutedEventArgs e)
        {
            BonusWindow bonusWindow = new BonusWindow();
            bonusWindow.ShowDialog();
        }

        private void BtnStatus_Click(object sender, RoutedEventArgs e)
        {
            StatusWindow statusWindow = new StatusWindow();
            statusWindow.ShowDialog();
        }

        private void BtnSend_Click(object sender, RoutedEventArgs e)
        {
            SendWindow sendWindow = new SendWindow();
            sendWindow.ShowDialog();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
