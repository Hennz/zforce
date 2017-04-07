using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_manager
{
    class User
    {

        DbConnector dbconnector = new DbConnector();
        bool RegisterUser(User user)
        {
            if (dbconnector.registerUser(user))
                return true;
            return false;

        }
        
        //To get the user Details after Login
        User getUserDetails(User user)
        {
            user=dbconnector.getUserDetails(user);
            //check if user is null
            return user;
        }
     
        // To Authnenticate user
        
        bool authenticateUser(String username, String password)
        {
            if (dbconnector.authenticateUser(username,password))
                Return true;
            else
                return false;
        }
                
        //To check if the username is unique or not
        bool checkUsername(String username)
        {
            if(dbconnector.checkUsername(username))
                Return true;
            else
                return false;
        }
        
        //To check if the mobile is unique or not
        bool checkMobile(int mobile)
        {
            if(dbconnector.checkMobile(username))
                Return true;
            else
                return false;
        }
        
         //To check if the Email is unique or not
        bool checkEmail(String email)
        {
            if(dbconnector.checkEmail(username))
                Return true;
            else
                return false;
        }
                    
   
    
    
    }   
}
