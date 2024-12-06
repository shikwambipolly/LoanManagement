using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LOANMANAGEMENTAPI.Data;
using LOANMANAGEMENTAPI.Models;

namespace LOANMANAGEMENTAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InterestPaidController : ControllerBase
    {
        private readonly AppDbContext _context;

        public InterestPaidController(AppDbContext context)
        {
            _context = context;
        }

        // Get all outstanding
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Interest_Paid>>> GetBorrowers()
        {
            return await _context.InterestPaid.ToListAsync();
        }
    }
}