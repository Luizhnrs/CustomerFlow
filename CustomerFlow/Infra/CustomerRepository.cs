using CustomerFlow.Model;

namespace CustomerFlow.Infra
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public void Add(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public List<Customer> Get()
        {
            return _context.Customers.ToList();
        }
    }

}
