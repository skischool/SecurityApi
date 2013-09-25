using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Domain.MainModule.Data.Configuration
{
    public class CustomDatabaseInitializer : DropCreateDatabaseIfModelChanges<DataContext> 
    {
        
    }

}
