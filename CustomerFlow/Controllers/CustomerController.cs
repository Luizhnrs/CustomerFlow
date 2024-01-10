using CustomerFlow.Model;
using CustomerFlow.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices.Marshalling;


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
        public IActionResult Add([FromForm] CustomerViewModel customerView)
        {
            var filepath = Path.Combine("Storage", customerView.Photo.FileName);

            using Stream filestream = new FileStream(filepath, FileMode.Create);
            customerView.Photo.CopyTo(filestream);

            var customer = new Customer(customerView.Name, customerView.Age, null);
            _customerRepository.Add(customer);
            return Ok();
        }
        [HttpGet]
        public IActionResult Get()
        {
            var customer = _customerRepository.Get();
            return Ok (customer);
        }
    }
}
