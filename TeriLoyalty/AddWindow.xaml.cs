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
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        Loyalties _currentLoyalty ;
        public AddWindow()
        {
            InitializeComponent();
            _currentLoyalty = new Loyalties(loyaltyBox.Text);
        }

        private void BtnSaveText_Click(object sender, RoutedEventArgs e)
        {
            //if (_currentLoyalty.id == 0)

            DataBase.RunSQL("SET IDENTITY_INSERT Loyalties ON");
            teriEntities2.GetContext().Loyalties.Add(_currentLoyalty);

            try
            {
               
                teriEntities2.GetContext().SaveChanges();
                DataBase.RunSQL("SET IDENTITY_INSERT Loyalties OFF");
                MessageBox.Show("Информация сохранена");
                Manager.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
