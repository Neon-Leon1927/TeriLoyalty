﻿using System;
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
    /// Логика взаимодействия для StatusWindow.xaml
    /// </summary>
    public partial class StatusWindow : Window
    {
        public StatusWindow()
        {
            InitializeComponent();
            DStatusClients.ItemsSource = teriEntities2.GetContext().Clients.ToList();
            DataBase.OpenConnection();
        }

        private void DStatusClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
