using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerFlow.Model
{
    [Table("customer")]
    public class Customer
    {
        [Key]
        public Guid id { get; private set; }
        public string name { get; private set; }
        public int age { get; private set; }

        public string? photo { get; private set; }

        public Customer() 
        {
            id = Guid.NewGuid();
        }

        public Customer(string name, int age, string photo)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.age = age;
            this.photo = photo;
        }
    }
}
