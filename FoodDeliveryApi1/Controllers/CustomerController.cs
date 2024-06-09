using FoodDeliveryApi1.Data;
using FoodDeliveryApi1.DTOs;
using FoodDeliveryApi1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApi1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(CustomerRegisterDto registerDto)
        {
            if (_context.Customers.Any(c => c.Email == registerDto.Email))
            {
                return BadRequest("Email is already in use.");
            }

            var customer = new Customer
            {
                Name = registerDto.Name,
                Email = registerDto.Email,
                Password = registerDto.Password, // Storing password as plain text
                Address = registerDto.Address,
                Phone = registerDto.Phone
            };

            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Registration successful" });
        }

    }
}