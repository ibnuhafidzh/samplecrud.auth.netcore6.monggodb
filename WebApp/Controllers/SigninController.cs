using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Controllers
{
    public class SigninController : Controller
    {
        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> signInManager;
        private RoleManager<ApplicationRole> roleManager;

        public SigninController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser appUser = await userManager.FindByEmailAsync(loginModel.Email);
                if (appUser != null)
                {
                    try
                    {
                        await signInManager.SignOutAsync();
                        Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(appUser, loginModel.Password, false, false);
                        if (result.Succeeded)
                        {
                            var claims = await userManager.GetClaimsAsync(appUser);
                            if (claims.Any())
                            {
                                foreach (var itemclaim in claims)
                                {
                                    try
                                    {
                                        Claim claim = new Claim(itemclaim.Type, itemclaim.Value, ClaimValueTypes.String);
                                        IdentityResult resultrole = await userManager.AddClaimAsync(appUser, claim);
                                    }
                                    catch
                                    {

                                    }
                                }
                            }
                            foreach (var itemuser in appUser.Roles)
                            {
                                var foundroles = roleManager.Roles.Where(pp => pp.Id == itemuser).ToList();
                                if (foundroles.Any())
                                {
                                    foreach (var itemrole in foundroles)
                                    {
                                        try
                                        {
                                            var claim = new Claim(ClaimTypes.Role, itemrole.Name);
                                            IdentityResult resultrole = await userManager.AddClaimAsync(appUser, claim);
                                        }
                                        catch
                                        {

                                        }
                                    }
                                }
                            }

                            var routeValue = new RouteValueDictionary
                 (new { action = "Index", controller = "Product" });
                            return RedirectToRoute(routeValue);
                        }
                        else
                        {
                            ModelState.AddModelError(nameof(loginModel.Email), "Login Failed: Invalid Email or Password");
                            return View(loginModel);
                        }
                    }
                    catch
                    {
                        ModelState.AddModelError(nameof(loginModel.Email), "Login Failed: Invalid Email or Password");
                        return View(loginModel);
                    }

                }
                else
                {
                    ModelState.AddModelError(nameof(loginModel.Email), "Login Failed: Invalid Email or Password");
                    return View(loginModel);
                }

            }

            return View();
        }
    }
}