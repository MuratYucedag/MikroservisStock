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
    public class RegistersController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public RegistersController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> UserRegister(UserRegisterDto userRegisterDto)
        {
            var values = new ApplicationUser()
            {
                UserName = userRegisterDto.Username,
                Name = userRegisterDto.Name,
                Surname = userRegisterDto.Surname,
                City = userRegisterDto.City,
                District = userRegisterDto.District,
                Email = userRegisterDto.Email
            };
            await _userManager.CreateAsync(values, userRegisterDto.Password);
            return Ok("Kullanıcı başarıyla eklendi");
        }
    }
}
