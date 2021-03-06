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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cafe_manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User user= new User();
        public MainWindow()
        {
            InitializeComponent();
        }
        
        
        // To open the Registration window
        private void btn_signup_Click(object sender, RoutedEventArgs e)
        {
         //open the Registration window
         registration regForm = new registration();
         regForm.ShowDialog();
        }
        
        // To open the ForgotPassword Window window
        private void btn_forgotpassword_Click(object sender, RoutedEventArgs e)
        {
            //open the Forgot password window
        }

        // To authenticate the user
        private void btn_signin_Click(object sender, RoutedEventArgs e)
        {
            string userName = text_username.Text.ToString();
            string password = text_password.Password.ToString();
            
            if(userName == "" || password == "")
            {
            //Error  msg
            return;
            }
             if (user.authenticateUser(userName, password))
                {
                user.Username = userName;
                user = user.getUserDetailsByName(user);
                Client_Home client_Home = new Client_Home(user);
                this.Hide();
                client_Home.Show();
                 }
                else
                MessageBox.Show("Failure");
        }

      

        //End braces
    }
}
