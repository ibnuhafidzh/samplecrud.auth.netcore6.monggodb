using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;
using WebApp.Models;
using WebApp.Models.admin;
using WebApp.Services;

namespace WebApp.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly ProductService Service;
        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> signInManager;
        public ProductController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ProductService Services)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            Service = Services;
        }
        public IActionResult Index()
        {
            var srole = "";
            try
            {
                var roleuser = User.Identities.FirstOrDefault().Claims.Where(pp => pp.Type == User.Identities.FirstOrDefault().RoleClaimType).ToList();
                if (roleuser.Any())
                {
                    srole = roleuser.FirstOrDefault().Value;
                }
            }
            catch
            {

            }
            ViewBag.DTR = srole;
            return View(Service.Get());
        }

        public IActionResult Create()
        {
            var srole = "";
            try
            {
                var roleuser = User.Identities.FirstOrDefault().Claims.Where(pp => pp.Type == User.Identities.FirstOrDefault().RoleClaimType).ToList();
                if (roleuser.Any())
                {
                    srole = roleuser.FirstOrDefault().Value;
                }
            }
            catch
            {

            }
            ViewBag.DTR = srole;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product data)
        {
            if (!string.IsNullOrEmpty(data.Name))
            {
                try
                {
                    //var byteimg = GetStreamFromUrl(data.link);
                    data.userid = userManager.Users.First().Id.ToString();
                    Service.Create(data);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {

                }
            }
            return View(data);
        }
        // GET: Cars/Delete/5
        public ActionResult Delete(string id)
        {
            var srole = "";
            try
            {
                var roleuser = User.Identities.FirstOrDefault().Claims.Where(pp => pp.Type == User.Identities.FirstOrDefault().RoleClaimType).ToList();
                if (roleuser.Any())
                {
                    srole = roleuser.FirstOrDefault().Value;
                }
            }
            catch
            {

            }
            if (id == null)
            {
                return NotFound();
            }

            var data = Service.Get(id);
            if (data == null)
            {
                return NotFound();
            }
            return View(data);
        }

        // POST: Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            var srole = "";
            try
            {
                var roleuser = User.Identities.FirstOrDefault().Claims.Where(pp => pp.Type == User.Identities.FirstOrDefault().RoleClaimType).ToList();
                if (roleuser.Any())
                {
                    srole = roleuser.FirstOrDefault().Value;
                }
            }
            catch
            {

            }
            try
            {
                var data = Service.Get(id);

                if (data == null)
                {
                    return NotFound();
                }

                Service.Remove(data.Id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Details(string id)
        {
            var srole = "";
            try
            {
                var roleuser = User.Identities.FirstOrDefault().Claims.Where(pp => pp.Type == User.Identities.FirstOrDefault().RoleClaimType).ToList();
                if (roleuser.Any())
                {
                    srole = roleuser.FirstOrDefault().Value;
                }
            }
            catch
            {

            }
            if (id == null)
            {
                return NotFound();
            }

            var car = Service.Get(id);

            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }
        [Route("Product/Edit")]
        public IActionResult Edit()
        {
            var srole = "";
            try
            {
                var roleuser = User.Identities.FirstOrDefault().Claims.Where(pp => pp.Type == User.Identities.FirstOrDefault().RoleClaimType).ToList();
                if (roleuser.Any())
                {
                    srole = roleuser.FirstOrDefault().Value;
                }
            }
            catch
            {

            }
            return View();
        }
        [Route("Product/Edit/{id}")]
        public ActionResult Edit(string id)
        {
            var srole = "";
            try
            {
                var roleuser = User.Identities.FirstOrDefault().Claims.Where(pp => pp.Type == User.Identities.FirstOrDefault().RoleClaimType).ToList();
                if (roleuser.Any())
                {
                    srole = roleuser.FirstOrDefault().Value;
                }
            }
            catch
            {

            }

            if (id == null)
            {
                return NotFound();
            }

            var car = Service.Get(id);
            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Product/Edit/{id}")]
        [Authorize]

        public async Task<IActionResult> Edit(string id, Models.admin.Product data)
        {
            if (id != data.Id)
            {
                return NotFound();
            }
            if (!string.IsNullOrEmpty(data.Name))
            {
                Service.Update(id, data);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(data);
            }
        }
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            var routeValue = new RouteValueDictionary
              (new { action = "Index", controller = "Home" });
            return RedirectToRoute(routeValue);
        }
    }
}
