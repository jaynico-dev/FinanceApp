using FinanceApp.Data;
using FinanceApp.Data.Service;
using FinanceApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Controllers
{
    // Handles backend logic of Application
    public class ExpensesController : Controller
    {
        private readonly IExpensesService _expensesService;
        public ExpensesController(IExpensesService expensesService)
        {
            _expensesService = expensesService;
        }
        public async Task<IActionResult> Index()
        {
            // Fetches all data (expenses) from the database
            var expenses = await _expensesService.GetAll();
            return View(expenses);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Expense expense)
        {
            // Add and Save data (expense) to the database
            if (ModelState.IsValid)
            {
                await _expensesService.Add(expense);

                return RedirectToAction("Index");
            }

            return View(expense);
        }
        public IActionResult GetChart()
        {
            var data = _expensesService.GetChartData();
            return Json(data);
        }
    }
}
