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
    /// Логика взаимодействия для BonusWindow.xaml
    /// </summary>
    public partial class BonusWindow : Window
    {
        public BonusWindow()
        {
            InitializeComponent();
        }

        private void BtnBonus_Click(object sender, RoutedEventArgs e)
        {
            DataBase.OpenConnection();
            DataBase.RunSQL("UPDATE Clients set Bonus" +
                "= ('" + BonusBox.Text + "') " +
                "WHERE FIO LIKE ('"+ FIOBox.Text + "')" );
            DataBase.CloseConnection();
            MessageBox.Show("Бонусы зачисленны");
            this.Close();
        }
    }
}
