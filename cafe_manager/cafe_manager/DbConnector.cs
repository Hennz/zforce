using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace cafe_manager
{
    class DbConnector
    {
        private static MySqlConnection sqlConnection;
        private static string server;
        private static string database;
        private static string Userid;
        private static string password;

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyy-MM-dd HH:mm:ss");
        }

        //Constructor to create CONNECTION STRING 
        public DbConnector()
        {
            //server = "192.168.0.2";
            server = "localhost";
            database = "cafe_manager";
            Userid = "root";
            password = "root";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + Userid + ";" + "PASSWORD=" + password + ";";

            sqlConnection = new MySqlConnection(connectionString);
        }


        // To open the connection
        private bool OpenConnection()
        {
            try
            {
                sqlConnection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
             }
          }


        //To close the connection
        private bool CloseConnection()
        {
            try
            {
                sqlConnection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
        
        //To Register User
        bool registerUser(User user)
        {
            // Code to register user
        }   
        
        // To get the user Details
        User getUserDetails(User user)
        {
         // code to gee the user details from the user id
            
            return user;
        }
 
        // To authenticate user
         bool authenticateUser(String username, String password)
         {
             /*Query if username exists, If exists then compare the password, If matches return true otherwise false*/
         }
        
        //To check if the username is unique or not
        bool checkUsername(String username)
        {
            //query database if the username is unique or not
        }
             
         //To check if the mobile is unique or not
        bool checkUsername(int mobile)
        {
            //query if the mobilenumber is unique or not
        }
        
         //To check if the Email is unique or not
        bool checkEmail(String email)
        {
            //Query database for the email uniqueness check
        }
        
        

  }
}
