using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Controllers
{
    public class CuentaController : Controller
    {
        private UserManager<IdentityUser> _um;
        private SignInManager<IdentityUser> _sim;
        public CuentaController(UserManager<IdentityUser> um, SignInManager<IdentityUser> sim)
        {
            _um = um;
            _sim = sim;
        }

        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registro(string correo, string usuario, string password)
        {
            var identityUser = new IdentityUser(usuario);
            identityUser.Email = correo;

            var result = _um.CreateAsync(identityUser, password).Result;

            if (result.Succeeded)
            {
                return RedirectToAction("index", "home");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("usuario", error.Description);
            }

            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string usuario, string password)
        {
            var result = _sim.PasswordSignInAsync(usuario, password, false, false).Result;

            if (result.Succeeded)
            {
                return RedirectToAction("index", "home");
            }

            ModelState.AddModelError("usuario", "Datos incorrectos");

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _sim.SignOutAsync();
            return RedirectToAction("index", "home");
        }
    }
}