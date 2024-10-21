using ApiProduct.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace ApiProduct.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(ProductDbContext context) : ControllerBase
    {
        private readonly ProductDbContext _context = context;

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductId(Guid id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null) { 
                return NotFound();
            }
            return product;
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct([FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProductId), new { id = product.ID}, product);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]    
        public async Task<IActionResult> PutProduct(Guid id, [FromBody] Product product)
        {
            if (id != product.ID) 
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Products.Any(e => e.ID == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
         
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
