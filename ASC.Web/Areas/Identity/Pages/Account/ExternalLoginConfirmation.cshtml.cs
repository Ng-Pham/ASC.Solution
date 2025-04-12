using ASC.Model.BaseTypes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using static System.Net.Mime.MediaTypeNames;

namespace ASC.Web.Areas.Identity.Pages.Account
{
    public class ExternalLoginConfirmationModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<ExternalLoginConfirmationModel> _logger;

        public ExternalLoginConfirmationModel(
            SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager,
            ILogger<ExternalLoginConfirmationModel> logger)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = logger;
        }
        public void OnGet()
        {
        }
        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }
        }
        /*public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            if (ModelState.IsValid)
            {
                var info = await _signInManager.GetExternalLoginInfoAsync();
                if (info == null)
                {
                    return RedirectToPage("./Login");
                }

                var user = new IdentityUser { UserName = Input.Email, Email = Input.Email, EmailConfirmed = true };
                var result = await _userManager.CreateAsync(user);

                if (result.Succeeded)
                {
                    await _userManager.AddClaimAsync(user, new Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress", Input.Email));
                    await _userManager.AddClaimAsync(user, new Claim("IsActive", "true"));

                    result = await _userManager.AddLoginAsync(user, info);
                    if (result.Succeeded)
                    {
                        var roleResult = await _userManager.AddToRoleAsync(user, Roles.User.ToString());
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect("~/ServiceRequests/Dashboard/Dashboard");
                    }
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            ViewData["ReturnUrl"] = returnUrl;
            return Page();
        }*/


    }
}   
