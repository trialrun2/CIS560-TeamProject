using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessLibrary
{
    public static class PasswordHandler
    {
        public static bool Authenticate(string username, string password, DatabaseHandler database, out int personId)
        {            
            var auth = database.GetPasswordHash(username, out int id);
            personId = id;

            if (auth == password) return true;
            return false;
        }
    }
}
