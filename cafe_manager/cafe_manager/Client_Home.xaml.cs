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
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
