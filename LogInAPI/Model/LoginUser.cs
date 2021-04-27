using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogInAPI.Model
{
    public class LoginUser
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public string UserName { get; set; }
        public string StreetNo { get; set; }
        public string Email { get; set; }
    }
}
