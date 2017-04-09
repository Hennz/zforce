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
            lbl_er_name_msg.Content = ("");
            lbl_er_email_msg.Content = ("");
            lbl_er_username_msg.Content = ("");
            lbl_er_confirmpassword_msg.Content = ("");
            lbl_er_password_msg.Content = ("");
            lbl_er_dob_msg.Content = ("");
            lbl_er_gender_msg.Content = ("");
            lbl_er_mobile_msg.Content = ("");
            lbl_er_city_msg.Content = ("");
            lbl_er_state_msg.Content = ("");
            lbl_er_country_msg.Content = ("");
            lbl_er_pincode_msg.Content = ("");
            lbl_registartion_field_msg.Content = ("");

            
        

            //Check if all the details filled are valid
            //call the userRegisration method to register the user
            string username = txt_username.Text.ToString();
            string password = txt_password.Password.ToString();
            string confirmpassword = txt_confirmpassword.Password.ToString();
            string name = txt_name.Text.ToString();
            string email = txt_email.Text.ToString();
            string mobile = txt_mobile.Text.ToString();
            DateTime? birthdate=dp_dob.SelectedDate;
            string city = txt_city.Text.ToString();
            string state = txt_state.Text.ToString();
            string country = txt_country.Text.ToString();
            string pin = txt_pincode.Text.ToString();
            string gender;



            if (gender_male.IsEnabled)
            { gender = "Male";
            }
            if (gender_female.IsEnabled)
            { gender = "Female";
            }

            if (username == "" || password == "" || name == "" || email == "" || mobile == "" || city == "" || birthdate== null|| state == "" || pin == "" || country == "" || (gender_male.IsEnabled == false && gender_female.IsEnabled == false))
            {
                lbl_registartion_field_msg.Content = ("Please Enter details in all the *(Mandatory) fields");
                return;
            }
            if (Regex.IsMatch(username, @"^[a-zA-Z0-9_]{5,20}$") == false)
            {
                lbl_er_username_msg.Content = ("Enter correct Username");
                return;
            }
            if (password.Length < 5)
            {
                lbl_er_password_msg.Content = ("Password length is short (Length should be more than 5 character)");
                return;
            }
            if (! password.Equals(confirmpassword))
            {    lbl_er_confirmpassword_msg.Content = ("Password does not match");
                return;
             }
            if (Regex.IsMatch(name, @"^[a-zA-Z]+$") == false)
            {
                lbl_er_name_msg.Content = ("Enter Correct Name");
                return;
            }
           
            try
                {
                if (Regex.IsMatch(mobile, @"^([7-9]{1})([0-9]{9})$") == false)
                {
                    lbl_er_mobile_msg.Content = ("Enter valid 10 digits Mobile Number");
                    return;
                }
                }
                catch (System.NullReferenceException)
                {
                    lbl_er_name_msg.Content =("Enter valid 10 digits Mobile Number");

                }
                if (Regex.IsMatch(email, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$") == false)
                {
                    lbl_er_email_msg.Content = ("Enter valid Email Id Email");
                    return;
                }

            DateTime currentDate = DateTime.Now;
            DateTime d = Convert.ToDateTime(birthdate);
            TimeSpan dif = currentDate.Subtract(d);

                if (dif.TotalDays<4745)
                {
                lbl_er_dob_msg.Content = ("User should be above 13 years");
                return;
                }

                if (Regex.IsMatch(pin, @"^[4][0-9]{5}$") == false)
                {
                    lbl_er_pincode_msg.Content = ("Enter correct Pin");
                    return;
                }
                if (Regex.IsMatch(city, @"^[a-zA-Z]+$") == false)
                {
                    lbl_er_city_msg.Content = ("Enter Correct city");
                    return;
                }

                if (Regex.IsMatch(state, @"^[a-zA-Z]+$") == false)
                {
                    lbl_er_state_msg.Content = ("Enter Correct State");
                    return;
                }
                if (user.checkUsername(username))
                {
                    lbl_er_username_msg.Content = ("Username Exists");
                    return;
                }
                if (user.checkEmail(email))
                {
                    lbl_er_email_msg.Content = ("Email Exists");
                    return;
                }

                if (user.checkMobile(mobile))
                {
                    lbl_er_mobile_msg.Content = ("Mobile number Exists");
                    return;
                }

                
            }

        private void btn_check_user_availability_Click(object sender, RoutedEventArgs e)
        {
            string username = txt_username.Text.ToString();
            if (username == "" )
            {
                lbl_registartion_field_msg.Content = ("Please Enter valid username");
                return;
            }
            if (user.checkUsername(username))
            {
                lbl_er_username_msg.Content = ("Username Exists");
            }
            if(!user.checkUsername(username))
            { }
                lbl_er_username_msg.Content = ("Username Available");
                return;
            }
        }
        //Birthdate Age verification code needs to be written to verify if age is greater than 13 years

    }
    

