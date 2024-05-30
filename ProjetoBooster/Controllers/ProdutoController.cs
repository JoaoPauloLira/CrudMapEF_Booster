using Microsoft.AspNetCore.Mvc;
using ProjetoBooster.Business;
using ProjetoBooster.Entities;

namespace ProjetoBooster.Controllers
{
    //https://localhost:7077/swagger/index.html
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoBusiness _produtoService;

        public ProdutoController(IProdutoBusiness produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Produto>>> GetAll()
        {
            var produtos = await _produtoService.GetAll();
            return Ok(produtos);
        }

        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<Produto>> GetById(int id)
        {
            var produto = await _produtoService.GetById(id);
            if (produto == null)
                return NotFound();
            return Ok(produto);
        }

        [HttpPost("Add")]
        public async Task<ActionResult> Add([FromBody] Produto produto)
        {
            await _produtoService.Add(produto);
            return CreatedAtAction(nameof(GetById), new { id = produto.Id }, produto);
        }

        [HttpPut("Update/{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] Produto produto)
        {
            if (id != produto.Id)
                return BadRequest();

            await _produtoService.Update(produto);
            return NoContent();
        }

        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _produtoService.Delete(id);
            return NoContent();
        }
    }
}
