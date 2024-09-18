using EcommerceAPI.Data;
using EcommerceAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly EcommerceDbContext _context;

        public ProductController(EcommerceDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchProducts([FromQuery] string name)
        {
            var products = await _context.Products.Where(p => p.Name.Contains(name)).ToListAsync();
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody]Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct([FromBody] Product product)
        {
            var updateProduct = await _context.Products.FindAsync(product.Id);
            if(updateProduct == null)
            {
                return NotFound("Product not found");
            }
            updateProduct.Name = product.Name;
            updateProduct.Description = product.Description;
            updateProduct.Price = product.Price;
            updateProduct.Category = product.Category;
            updateProduct.CreatedDate = product.CreatedDate;
            updateProduct.UpdatedDate = DateTime.Now;

            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete()]
        public async Task<IActionResult> DeleteProduct([FromQuery] int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound("Product not found");
            }
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
