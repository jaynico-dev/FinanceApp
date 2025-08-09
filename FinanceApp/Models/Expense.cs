using System.ComponentModel.DataAnnotations;

namespace FinanceApp.Models
{
    public class Expense
    {
        public int Id { get; set; }
        [Required]
        [Range(0.1, double.MaxValue, ErrorMessage = "Amount needs to be heigher than 0")]
        public string Description { get; set; } = null!;
        [Required]
        public double Amount { get; set; }
        [Required]
        public string Category { get; set; } = null!;
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
