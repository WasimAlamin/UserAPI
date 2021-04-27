
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

        //public DbSet<User> Users { get; set; }
        //public DbSet<Role> Roles{ get; set; }
        public MyContext(DbContextOptions<MyContext> options) : base(options) 
        {
        
        
        }
    }
}
