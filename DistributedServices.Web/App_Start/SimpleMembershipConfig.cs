using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.WebData;

namespace DistributedServices.Web.App_Start
{
    public static class SimpleMembershipConfig
    {
        public static void Register()
        {
            var connectionString = "ApplicationServices";

            var usersTable = "Users";

            var usersTableKeyColumn = "Id";

            var usersTableUserNameColumn = "Username";
            
            WebSecurity.InitializeDatabaseConnection(connectionString, usersTable, usersTableKeyColumn, usersTableUserNameColumn, true);
        }
    }
}