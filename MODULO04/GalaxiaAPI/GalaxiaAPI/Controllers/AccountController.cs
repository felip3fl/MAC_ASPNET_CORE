using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GalaxiaAPI.Model;
using GalaxiaAPI.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GalaxiaAPI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<MeuUserIdentity> userManager;
        private readonly SignInManager<MeuUserIdentity> loginManager;
        private readonly RoleManager<MeuRoleIdentity> roleManager;

        public AccountController(UserManager<MeuUserIdentity> userManager,
            SignInManager<MeuUserIdentity> loginManager,
            RoleManager<MeuRoleIdentity> roleManager)
        {
            this.userManager = userManager;
            this.loginManager = loginManager;
            this.roleManager = roleManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel obj)
        {
            if (ModelState.IsValid)
            {
                var result = loginManager.PasswordSignInAsync(obj.UserName, obj.Password, obj.RememberMe, false).Result;

                if (result.Succeeded)
                {
                    return Content("Usuário Autorizado");
                }

                ModelState.AddModelError("", "Login Invalido!");
            }

            return View(obj);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel obj)
        {
            if (ModelState.IsValid)
            {
                MeuUserIdentity user = new MeuUserIdentity();
                user.UserName = obj.UserName;
                user.Email = obj.Email;

                IdentityResult result = userManager.CreateAsync(user, obj.Password).Result;

                if (result.Succeeded)
                {
                    if (!roleManager.RoleExistsAsync("Admin").Result)
                    {
                        MeuRoleIdentity role = new MeuRoleIdentity();
                        role.Name = "Admin";
                        role.Descricao = "Realiza operações básicas.";
                        IdentityResult roleResult = roleManager.
                        CreateAsync(role).Result;
                        if (!roleResult.Succeeded)
                        {
                            ModelState.AddModelError("", "Error ao criar o perfil!");
                            return View(obj);
                        }
                    }

                    userManager.AddToRoleAsync(user, "Admin").Wait();
                    return RedirectToAction("Login", "Account");
                }
            }
            return View(obj);
        }

    }
}
