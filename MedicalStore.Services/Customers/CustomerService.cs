using MedicalStore.Core.Data;
using MedicalStore.Core.Domain.Customers;

namespace MedicalStore.Services.Customers
{
    public class CustomerService:ICustomerService
    {
        private readonly IRepository<Customer> _customeRepository;
        private readonly IRepository<Role> _roleRepository;

        public CustomerService(IRepository<Customer> customeRepository,
            IRepository<Role> roleRepository)
        {
            _customeRepository = customeRepository;
            _roleRepository = roleRepository;
        }
    }
}
