using System.ComponentModel.DataAnnotations;

namespace EFCore.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
    }
}
