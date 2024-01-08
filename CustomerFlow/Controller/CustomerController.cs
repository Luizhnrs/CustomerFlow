using CustomerFlow.Model;
using CustomerFlow.ViewModel;
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
        [HttpPost]
        public IActionResult Add(CustomerViewModel customerView)
        {
            var customer = new Customer(customerView.Name, customerView.Age, null);
            _customerRepository.Add(customer);
            return Ok();
        }

        public IActionResult Get()
        {
            var customer = _customerRepository.get();
            return Ok(customer);
        }
    }
}
