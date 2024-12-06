using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LOANMANAGEMENTAPI.Data;
using LOANMANAGEMENTAPI.Models;

namespace LOANMANAGEMENTAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class LoansController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LoansController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet("multiple")]
        public async Task<ActionResult<IEnumerable<Loans>>> Multiple()
        {
            var result = await _context.Loans
                .GroupBy(l => l.BorrowerID)
                .Where(g => g.Count() > 1)
                .Select(g => new
                {
                    BorrowerID = g.Key,
                    Occurrences = g.Count()
                })
                .ToListAsync();

            if (!result.Any()) {
               return Content("Empty");
            }

            return Ok(result);
        }

        [HttpGet("near/{days}")]
        public async Task<ActionResult<IEnumerable<Loans>>> Near(int days)
        {
            var today = DateTime.Today;
            var targetDate = today.AddDays(days);

            var results = await _context.Loans
                .Where(row => row.LoanEndDate >= today && row.LoanEndDate <= targetDate)
                .ToListAsync();

            if (!results.Any()) {
                return Content("Empty");
            }

            return Ok(results);
        }
    }
}