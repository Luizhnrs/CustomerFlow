namespace CustomerFlow.Model
{
    public interface ICustomerRepository
    {
        void Add(Customer customer);

        List<Customer> Get();
    }
}
