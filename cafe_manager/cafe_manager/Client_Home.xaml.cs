using System;
using System.Threading;
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

namespace cafe_manager
{
    /// <summary>
    /// Interaction logic for Client_Home.xaml
    /// </summary>
    public partial class Client_Home : Window
    {
        User user;
        public Client_Home()
        {
            InitializeComponent();
        }
        public Client_Home(User user)
        {
            InitializeComponent();
            this.user = user;
            MessageBox.Show(user.Name);
            client_lbl_name.Content = user.Name;

            //create new thread to monitor the user login status
            ThreadStart newthread = new ThreadStart(isUserLogged);
            Thread monitorLoginStatus = new Thread(newthread);
            monitorLoginStatus.Start();

            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Logout_click(object sender, RoutedEventArgs e)
        {
            logout();

        }

        private void logout()
        {
            MainWindow login = new MainWindow();
            this.Close();
            login.Show();
        }

        public void isUserLogged()
        {
            while(true)
            {
                if (!user.monitorUserLogin(user.UserId))
                {
                    logout();
                }
                    
            }

        }


        //End braces
    }
}
