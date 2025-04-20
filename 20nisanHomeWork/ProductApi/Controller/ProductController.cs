using Microsoft.AspNetCore.Mvc;
using ProductApi.Models;
using ProductApi.Data;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository _repository;

        public ProductController(ProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_repository.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _repository.GetById(id);
            return product is not null ? Ok(product) : NotFound();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _repository.Add(product);
            return Created("", product);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Product product)
        {
            var existing = _repository.GetById(id);
            if (existing is null) return NotFound();
            _repository.Update(id, product);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existing = _repository.GetById(id);
            if (existing is null) return NotFound();
            _repository.Delete(id);
            return NoContent();
        }
    }
}
