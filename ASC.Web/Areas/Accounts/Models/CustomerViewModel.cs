using Microsoft.AspNetCore.Identity;

namespace ASC.Web.Areas.Accounts.Models
{
    public class CustomerViewModel
    {
        public List<IdentityUser> Customers { get; set; } = new List<IdentityUser>();
        public CustomerRegistrationViewModel Registration { get; set; }
    }
}
