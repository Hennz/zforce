using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_manager
{
    class User
    {
        string userId;
        string name;
        string username;
        string password;
        string email;
        string mobile;
        decimal walletAmount;
        string city;
        string state;
        string pincode;
        string country;
        public DateTime Dob;
        string gender;


        DbConnector dbconnector = new DbConnector();

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Mobile
        {
            get
            {
                return mobile;
            }

            set
            {
                mobile = value;
            }
        }

        public decimal WalletAmount
        {
            get
            {
                return walletAmount;
            }

            set
            {
                walletAmount = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }

        public string Pincode
        {
            get
            {
                return pincode;
            }

            set
            {
                pincode = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public string UserId
        {
            get
            {
                return userId;
            }

            set
            {
                userId = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public bool RegisterUser(User user)
        {
            if (dbconnector.registerUser(user))
                return true;
            return false;

        }
        
        //To get the user Details by name after Login
      public User getUserDetailsByName(User user)
        {
            user=dbconnector.getUserDetailsByName(user);
            //check if user is null
            return user;
        }
        //To get the user Details by name after Login
        public User getUserDetailsById(User user)
        {
            user = dbconnector.getUserDetailsById(user);
            //check if user is null
            return user;
        }

        // To Authnenticate user

        public bool authenticateUser(String username, String password)
        {
            if (dbconnector.authenticateUser(username,password))
                return true;
            else
                return false;
        }
                
        //To check if the username is unique or not
        public bool checkUsername(String username)
        {
            if(dbconnector.checkUsername(username))
                return true;
            else
                return false;
        }
        
        //To check if the mobile is unique or not
        public bool checkMobile(string mobile)
        {
            if(dbconnector.checkMobile(mobile))
                return true;
            else
                return false;
        }
        
         //To check if the Email is unique or not
        public bool checkEmail(String email)
        {
            if(dbconnector.checkEmail(Username))
                return true;
            else
                return false;
        }
                    
   
    
    // End semicolons
    }   
}
