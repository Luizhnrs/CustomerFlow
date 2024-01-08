using CustomerFlow.Model;
using Microsoft.AspNetCore.Mvc;

namespace CustomerFlow.Controller
{
    [ApiController]
    [Route("api/vi/customer")]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository));
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
