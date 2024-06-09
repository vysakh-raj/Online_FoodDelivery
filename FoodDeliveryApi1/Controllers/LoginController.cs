using FoodDeliveryApi1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FoodDeliveryApi1.DTOs;
using FoodDeliveryApi1.Data;

namespace FoodDeliveryApi1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Login(LoginDto loginDto)
        {
            // Check if the login credentials belong to an admin
            var admin = _context.Admins.FirstOrDefault(a => a.Email == loginDto.Email);
            if (admin != null && admin.PasswordHash == loginDto.Password)
            {
                // Return Ok with role as "admin"
                return Ok(new { role = "admin" });
            }

            // Check if the login credentials belong to a customer
            var customer = _context.Customers.FirstOrDefault(c => c.Email == loginDto.Email);
            if (customer != null && customer.Password == loginDto.Password)
            {
                // Return Ok with role as "customer"
                return Ok(new { role = "customer" });
            }

            // Invalid credentials
            return BadRequest("Invalid email or password.");
        }
    }
}
