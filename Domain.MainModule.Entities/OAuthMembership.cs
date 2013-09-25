using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.MainModule.Entities
{
    public class OAuthMembership
    {
        public string Provider { get; set; }
        public string ProviderUserId { get; set; }
        public int UserId { get; set; }
    }
}
