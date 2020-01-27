using System.Collections.Generic;
using System.Threading.Tasks;
using DDDCQRS.Domain.Command;
using DDDCQRS.Domain.Contracts;
using DDDCQRS.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DDDCQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        public readonly IMediator _mediator;
        public readonly IProdutoRepository _repository;

        public ProdutoController(IMediator mediator, IProdutoRepository produtoRepository)
        {
            _mediator = mediator;
            _repository = produtoRepository;
        }

        // GET: api/Produto
        [HttpGet]
        public Task<IEnumerable<Produto>> Get()
        {
            return  _repository.GetAll();
        }

        // GET: api/Produto/5
        [HttpGet("{id}", Name = "Get")]
        public Task<Produto> Get(int id)
        {
            return _repository.Buscar(c => c.id == id);
        }

        // POST: api/Produto
        [HttpPost]
        public IActionResult Post(RegisterProductCommand obj)
        {
            var prod = _mediator.Send(obj);

            return Ok(prod);
        }

        // PUT: api/Produto/5
        [HttpPut]
        public async Task<IActionResult> Put(UpdateProductCommand obj)
        {
            var prod = await _mediator.Send(obj);
            return Ok(prod);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(DeleteProductCommand obj)
        {
            var prod = await _mediator.Send(obj);
            return Ok(prod);
        }
    }
}
