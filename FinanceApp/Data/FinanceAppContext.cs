using FinanceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Data
{
    // This class represents the bridge between the application and the database.
    public class FinanceAppContext : DbContext
    {
        public FinanceAppContext(DbContextOptions<FinanceAppContext> options):base(options)
        {

        }

        DbSet<Expense> Expenses { get; set; }
    }
}
