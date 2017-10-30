using MedicalStore.Core.Domain.Customers;

namespace MedicalStore.Services.Authentication
{
    public interface IAuthenticationService
    {
        /// <summary>
        /// Signs the in.
        /// </summary>
        /// <param name="customer">The customer.</param>
        /// <param name="isPersistent">if set to <c>true</c> [is persistent].</param>
        void SignIn(Customer customer, bool isPersistent);

        /// <summary>
        /// Sign out
        /// </summary>
        void SignOut();

        /// <summary>
        /// Get authenticated customer
        /// </summary>
        /// <returns>Customer</returns>
        Customer GetAuthenticatedCustomer();
    }
}
