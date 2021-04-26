
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogInAPI.Model
{
    public class MyContext:IdentityDbContext<User,Role, int>
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) 
        {
        
        
        }
    }
}
