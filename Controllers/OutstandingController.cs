using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LOANMANAGEMENTAPI.Data;
using LOANMANAGEMENTAPI.Models;

namespace LOANMANAGEMENTAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OutstandingController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OutstandingController(AppDbContext context)
        {
            _context = context;
        }

        // Get all outstanding
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Outstanding_Amount>>> GetBorrowers()
        {
            return await _context.Outstanding.ToListAsync();
        }
    }
}