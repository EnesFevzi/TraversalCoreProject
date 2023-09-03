using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalProject.DtoLayer.Dtos.RegisterDto;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.WebUI.Controllers
{
    [AllowAnonymous]

    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
        public RegisterController(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateUserDto createUserDto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (createUserDto.Password != createUserDto.ConfirmPassword)
            {
                ModelState.AddModelError("", "Şifreler uyuşmuyor.");
                return View();
            }
            if (createUserDto.Password == createUserDto.ConfirmPassword)
            {

                var appUser = _mapper.Map<AppUser>(createUserDto);

                var result = await _userManager.CreateAsync(appUser, createUserDto.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View();
        }
    }
}
