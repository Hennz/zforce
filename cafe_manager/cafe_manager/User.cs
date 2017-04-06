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
    }
}
