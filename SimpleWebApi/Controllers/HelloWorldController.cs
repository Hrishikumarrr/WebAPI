using System;
using Microsoft.AspNetCore.Mvc;

namespace SimpleWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomProductsController : ControllerBase
    {
        //GET : shop/produtcs
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello, World!");
        }
        
        //GET: shop/products/details/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok("Hello, World! Your ID is {id}");
        }

        //post : api/heloworld
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return CreatedAtAction(nameof(GetById), new {ID =1}, value);
            
        }

        //PUT : api/helloworld/{id}
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            if(id <=0)
            {
                return BadRequest("Invalid ID");
            }
            return NoContent();

        }

        //DELETE: api/helloworld/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }

    } 
}
