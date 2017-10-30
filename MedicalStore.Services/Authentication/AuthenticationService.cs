using System.Security.Claims;
using System.Web;
using MedicalStore.Core.Domain.Customers;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace MedicalStore.Services.Authentication
{
    public class AuthenticationService:IAuthenticationService
    {

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.Current.GetOwinContext().Authentication;
            }
        }
        public void SignIn(Customer customer, bool isPersistent)
        {
            if (customer == null) return;
            var identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, customer.Pseudo)
                },
                DefaultAuthenticationTypes.ApplicationCookie,
                ClaimTypes.Name, ClaimTypes.Role);

            // if you want roles, just add as many as you want here (for loop maybe?)
            foreach (var userRole in customer.Roles)
            {
                identity.AddClaim(new Claim(ClaimTypes.Role, userRole.RoleName.ToLower()));
            }

            AuthenticationManager.SignIn(new AuthenticationProperties { IsPersistent = isPersistent }, identity);
        }

        public void SignOut()
        {
            throw new System.NotImplementedException();
        }

        public Customer GetAuthenticatedCustomer()
        {
            throw new System.NotImplementedException();
        }
    }
}
