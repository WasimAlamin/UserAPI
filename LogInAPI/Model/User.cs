using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogInAPI.Model
{
    public class User:IdentityUser<int>
    {
    }
}
