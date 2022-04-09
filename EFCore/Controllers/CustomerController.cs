using EFCore.Data;
using EFCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EFCore.Controllers
{
    public class CustomerController : Controller
    {
        private readonly OnlineShopDbContext _context;

        public CustomerController(OnlineShopDbContext context)
        {
            _context = context;
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Customer model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _context.Customer.AddAsync(model);
            return Ok();
        }
    }
}
