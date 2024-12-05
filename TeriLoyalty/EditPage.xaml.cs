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
using System.Data.SqlClient;

namespace TeriLoyalty
{
    /// <summary>
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        public EditPage()
        {
            InitializeComponent();
            DAppLoyalty.ItemsSource = teriEntities2.GetContext().Loyalties.ToList();
            DataBase.OpenConnection();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            addWindow.Show();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DAppLoyalty_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
