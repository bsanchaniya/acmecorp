using System.ComponentModel.DataAnnotations.Schema;

namespace AcmeCorpCustomerManagementAPI.Models
{
    [Table("customers")]
    public class Customer
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("name")]
        public required string Name { get; set; }

        [Column("email")]
        public required string Email { get; set; }
    }
}
