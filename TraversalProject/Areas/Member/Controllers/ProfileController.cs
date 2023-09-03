using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalProject.DtoLayer.Dtos.UserDto;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.WebUI.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public ProfileController(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var roles = await _userManager.GetRolesAsync(values);
            ViewBag.Roles = roles;
            var userEditViewModel = _mapper.Map<UserEditViewDto>(values);
            return View(userEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewDto userEditViewDto)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (userEditViewDto.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(userEditViewDto.Image.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = Path.Combine(resource, "wwwroot", "userimages", imageName);
                using var stream = new FileStream(saveLocation, FileMode.Create);
                await userEditViewDto.Image.CopyToAsync(stream);
                user.ImageUrl = imageName;
            }

            _mapper.Map(userEditViewDto, user);
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditViewDto.Password);

            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Profile");
            }

            return View();
        }
    }
}
