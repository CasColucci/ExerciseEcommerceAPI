using EcommerceAPI.Data;
using EcommerceAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Linq;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly EcommerceDbContext _context;

        public ProductController(EcommerceDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchProducts([FromBody] SearchProduct search)
        {
            var products = new List<Product>();
            if (search.Name == null && search.Category == null)
            {
                return BadRequest("Name or Category is required");
            }
            if(search.Name != null)
            {
                products = await _context.Products.Where(p => p.Name.Contains(search.Name)).ToListAsync();
            }    
            if(search.Category != null)
            {
                products = await _context.Products.Where(p => p.Category == search.Category).ToListAsync();
            }
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody]Product product)
        {
            product.CreatedDate = DateTime.Now;
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
