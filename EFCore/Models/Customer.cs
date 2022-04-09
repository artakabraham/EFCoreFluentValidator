using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCore.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal Height { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Address PrimaryAddress { get; set; }
        public List<Address> OtherAddresses { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}