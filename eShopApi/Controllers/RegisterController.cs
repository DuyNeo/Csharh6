using eShopShare.Models.ApiModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace eShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        public RegisterController(UserManager<AppUser> userManager)
        {

            _UserManager = userManager;

        }
        //private void CreatPassword(string password, out byte[] passwordHash, out byte[] passwordSatl)
        //{
        //    using (var hmac = new HMACSHA512())
        //    {
        //        passwordSatl = hmac.Key;
        //        passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password)); 
        //    }
        //}
      
        public UserManager<AppUser> _UserManager { get; }

        [HttpPost("dangky")]
        public async Task<IActionResult> PostUser(RegisterClientRequest model)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
                return BadRequest(errors);
            }

            var user = new AppUser { UserName = model.Email, Email = model.Email };

            try
            {
                var result = await _UserManager.CreateAsync(user, model.Password);
                if (!result.Succeeded)
                {
                    return Unauthorized(model);
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return Problem($"Something went wrong in the {nameof(PostUser)}", statusCode: 500);
            }

        }
    }
}
