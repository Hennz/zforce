using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for registration.xaml
    /// </summary>
    public partial class registration : Window
    {

        User user = new User();
        public registration()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, RoutedEventArgs e)
        {
            //Check if all the details filled are valid
            //call the userRegisration method to register the user
            string username = txt_username.Text.ToString();
            string password = txt_password.Password.ToString();
            string name = txt_name.Text.ToString();
            string email = txt_email.Text.ToString();
            string mobile = txt_mobile.Text.ToString();
            string birthdate = dp_birthdate.Text.ToString();
            string city = txt_city.Text.ToString();
            string state = txt_state.Text.ToString();
            string country = txt_country.Text.ToString();
            string pin = txt_pin.Text.ToString();
            string gender;
                if (gender_male.IsEnabled)
            { gender = "Male";
            }
                if (gender_female.IsEnabled)
            { gender = "Female";
            }

            if (username == "" || password == "" || name == "" || email == "" || mobile == "" || city == "" || state == "" || pin == "" || country == ""|| (gender_male.IsEnabled==false && gender_female.IsEnabled== false) )
            {
                MessageBox.Show("Please Enter details in all the *(Mandatory) fields");
                return;
            }
            if (Regex.IsMatch(username, @"^[a-zA-Z0-9_]{5,20}$") == false)
            {
                MessageBox.Show("Enter correct Username");
                return;
            }


        }
    }
}
