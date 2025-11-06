using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MikroservisStock.IdentityServer.Dtos;
using MikroservisStock.IdentityServer.Models;
using System.Threading.Tasks;

namespace MikroservisStock.IdentityServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginsController : ControllerBase
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        public LoginsController(SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpPost]
        public async Task<IActionResult> UserLogin(UserLoginDto userLoginDto)
        {
            var result = await _signInManager.PasswordSignInAsync(userLoginDto.Username, userLoginDto.Password,false,false);
            if(result.Succeeded)
            {
                return Ok("Giriş Başarılı");
            }
            else
            {
                return Ok("Hatalı Kullanıcı Adı veya Şifre");
            }
        }
    }
}
