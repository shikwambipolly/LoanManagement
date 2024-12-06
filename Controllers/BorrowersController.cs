using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LOANMANAGEMENTAPI.Data;
using LOANMANAGEMENTAPI.Models;

namespace LOANMANAGEMENTAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BorrowersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BorrowersController(AppDbContext context)
        {
            _context = context;
        }

        // Get all borrowers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Borrowers>>> GetBorrowers()
        {
            return await _context.Borrowers.ToListAsync();
        }

        // Get Borrowers by ID
        [HttpGet("{id}")]
        public async Task<ActionResult<Borrowers>> GetBorrower(int id)
        {
            var user = await _context.Borrowers.FindAsync(id);

            if (user == null)
                return NotFound();

            return user;
        }

        // Query users by name
        [HttpGet("search/{name}")]
        public async Task<ActionResult<IEnumerable<Borrowers>>> GetBorrowerByName(string name)
        {
            return await _context.Borrowers
                .Where(u => u.FullName.Contains(name))
                .ToListAsync();
        }
    }
}