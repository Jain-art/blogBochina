using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogBochina.Model.Common
{
    ///пользователь
    public class User : IdentityUser<int>
    {
        ///профиль пользователя
        public Employee Employee { get; set; }
    }
}
