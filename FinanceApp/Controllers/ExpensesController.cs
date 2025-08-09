using FinanceApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Controllers
{
    // Handles backend logic of Application
    public class ExpensesController : Controller
    {
        private readonly FinanceAppContext _context;
        public ExpensesController(FinanceAppContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var expenses = _context.Expenses.ToList();
            return View(expenses);
        }
    }
}
