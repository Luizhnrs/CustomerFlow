using System.ComponentModel.DataAnnotations;

namespace CustomerFlow.Model
{
    public class Customer
    {
        [Key]
        public int id { get; private set; }
        public string name { get; private set; }
        public int age { get; private set; }

        public string photo { get; private set; }
    }
}
