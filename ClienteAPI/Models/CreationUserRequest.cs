using System.ComponentModel.DataAnnotations;

namespace ClienteAPI.Models
{
    public class CreationUserRequest
    {
        [Required]
        public string TaxNumber { get; set; }
        public string FullName { get; set; }
        [Required]
        public decimal IncomeValue { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
    }
}
