using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwoFactorAuth.Domain.Entities
{
    public class VerifyCodeModel
    {
        private readonly string _code;
        private readonly string _username;

       public string UserName { get; private set; } = _username;
        
        public string Code { get; private set; } = _code;
        
        public VerifyCodeModel(string username,string code)
        {
            _username = username;
            _code = code;
            
            
        }
        
    }
}