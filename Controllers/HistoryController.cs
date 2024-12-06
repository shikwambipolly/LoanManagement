using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LOANMANAGEMENTAPI.Data;
using LOANMANAGEMENTAPI.Models;

namespace LOANMANAGEMENTAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HistoryController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HistoryController(AppDbContext context)
        {
            _context = context;
        }

        // Get all history
        [HttpGet]
        public async Task<ActionResult<IEnumerable<History>>> GetHistory()
        {
            return await _context.History.ToListAsync();
        }
    }
}