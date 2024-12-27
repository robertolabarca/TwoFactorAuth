using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwoFactorAuth.Domain.Entities
{
    public class TwoFactorAuthModel
    {
        private readonly string _username;
        
        public string UserName => _username;
        private readonly string _secretkey;
        
        public string SecretKey => _secretkey;
        
        
    }
}