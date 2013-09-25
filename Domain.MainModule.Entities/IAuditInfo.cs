using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.MainModule.Entities
{
    public interface IAuditInfo
    {
        DateTime CreatedOn { get; set; }
        DateTime ModifiedOn { get; set; }
    }
}
