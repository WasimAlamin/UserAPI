using LogInAPI.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LogInAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly UserManager<User> _useManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly MyContext _context;
        public LoginController(UserManager<User> userManager,
            SignInManager<User> signInManager,
            MyContext context,
            RoleManager<Role> roleManager)
        {

            _context = context;
            _useManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        // GET: api/<LoginController>
        [Route("login")]
        [HttpPost]
        public async Task<LoginUser> PostAsync([FromBody]LoginViewModel loginViewModel)
        {
            User u = new User();
            LoginViewModel loginView = new LoginViewModel();
            LoginUser Luser = new LoginUser();

            loginView.Status = false;
            var user = await _useManager.FindByNameAsync(loginViewModel.Username);

            if (user != null) 
            {
                var resultat = await _signInManager.CheckPasswordSignInAsync(user, loginViewModel.Password, false);

                if (resultat.Succeeded) 
                {
                    loginView.Status = true;

                    Luser.Id = user.Id;
                    Luser.Name = user.Na
                    Luser.StreetNo
                }
               
            }


           return loginView.Status;
            
        }



        [Route("Signup")]
        [HttpPost]
        public async Task<IActionResult> Signup ([FromBody] Signup signup)
        {
            User u = new User();
            u.UserName = signup.Username;
            u.Email = signup.Email;
         
           

            var newuser = await _useManager.CreateAsync(u, signup.Password);
            if (newuser.Succeeded) 
            {
                return Created(string.Empty, string.Empty);
             
            }
            return Problem(newuser.Errors.First().Description, null, 500);
        }

        [Route("delete")]
        [HttpDelete]
        public async Task<IActionResult> Deleteuser(int Id)
        {
           
            var user = await _useManager.FindByIdAsync(Id.ToString());

            var delete = await _useManager.DeleteAsync(user);

            if (delete.Succeeded) 
            {
            
            return Created(string.Empty, string.Empty);
            }
            return Problem(delete.Errors.First().Description, null, 500);
        }
    
    }
}
