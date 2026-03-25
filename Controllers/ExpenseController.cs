using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project2.Datas;

namespace Project2.Controllers
{
    [ApiController]
    [Route("api/expenses")]
    public class ExpenseController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ExpenseController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddExpense(Models.Expenses expense)
        {
            _context.expenses.Add(expense);
            await _context.SaveChangesAsync();
            return Ok(expense);
        }

        [HttpGet("trip/{tripId}")]
        public async Task<IActionResult> GetExpenses(int tripId)
        {
            var expenses = await _context.expenses
                .Where(e => e.TripId == tripId)
                .OrderByDescending(e => e.ExpenseDate)
                .ToListAsync();

            return Ok(expenses);
        }

        [HttpPut("{expenseId}")]
        public async Task<IActionResult> UpdateExpense(int expenseId, Models.Expenses expense)
        {
            if (expenseId != expense.ExpenseId)
                return BadRequest();

            _context.Entry(expense).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Ok(expense);
        }

        [HttpDelete("{expenseId}")]
        public async Task<IActionResult> DeleteExpense(int expenseId)
        {
            var expense = await _context.expenses.FindAsync(expenseId);

            if (expense == null)
                return NotFound();

            _context.expenses.Remove(expense);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
