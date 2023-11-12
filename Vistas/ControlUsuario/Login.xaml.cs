﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Vistas.ControlUsuario
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        public String Usuario 
        {
            get { return textuser.Text; }
        }

        public String Contraseña
        {
            get { return passwordBox1.Password; }
        }

        private void passwordBox1_PasswordChanged(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
