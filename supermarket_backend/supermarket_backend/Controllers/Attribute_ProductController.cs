using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using supermarket_backend.Model;

namespace supermarket_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Attribute_ProductController : ControllerBase
    {
        private readonly SuperMarketDBContext _context;

        public Attribute_ProductController(SuperMarketDBContext context)
        {
            _context = context;
        }

        // GET: api/Attribute_Product
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Attribute_Product>>> GetAttribute_Products()
        {
          if (_context.Attribute_Products == null)
          {
              return NotFound();
          }
            return await _context.Attribute_Products.ToListAsync();
        }

        // GET: api/Attribute_Product/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Attribute_Product>> GetAttribute_Product(int id)
        {
          if (_context.Attribute_Products == null)
          {
              return NotFound();
          }
            var attribute_Product = await _context.Attribute_Products.FindAsync(id);

            if (attribute_Product == null)
            {
                return NotFound();
            }

            return attribute_Product;
        }

        // PUT: api/Attribute_Product/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAttribute_Product(int id, Attribute_Product attribute_Product)
        {
            if (id != attribute_Product.Id)
            {
                return BadRequest();
            }

            _context.Entry(attribute_Product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Attribute_ProductExists(id))
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

        // POST: api/Attribute_Product
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Attribute_Product>> PostAttribute_Product(Attribute_Product attribute_Product)
        {
          if (_context.Attribute_Products == null)
          {
              return Problem("Entity set 'SuperMarketDBContext.Attribute_Products'  is null.");
          }
            _context.Attribute_Products.Add(attribute_Product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAttribute_Product", new { id = attribute_Product.Id }, attribute_Product);
        }

        // DELETE: api/Attribute_Product/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAttribute_Product(int id)
        {
            if (_context.Attribute_Products == null)
            {
                return NotFound();
            }
            var attribute_Product = await _context.Attribute_Products.FindAsync(id);
            if (attribute_Product == null)
            {
                return NotFound();
            }

            _context.Attribute_Products.Remove(attribute_Product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Attribute_ProductExists(int id)
        {
            return (_context.Attribute_Products?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
