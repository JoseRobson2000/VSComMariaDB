using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VSComMariaDB.Model;

namespace VSComMariaDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {

        [HttpGet]
        public List<Produto> GetLista()
        {
            var _DbContext = new _DbContext();
            var vLista = _DbContext.Produto.ToList();

            return vLista;

        }

        [HttpGet("{id}")]
        public async Task<Produto> GetProduto(int id)
        {
            var _DbContext = new _DbContext();

            var vProduto = await _DbContext.Produto.FindAsync(id);

            return vProduto;
        }

        [HttpPost]
        public async Task<Produto> Inserir(Produto produto)
        {
            var _DbContext = new _DbContext();

            await _DbContext.Produto.AddAsync(produto);
            await _DbContext.SaveChangesAsync();


            return produto;

        }


        [HttpPut]
        public async Task<Produto> Alterar(Produto produto)
        {
            var _DbContext = new _DbContext();

            _DbContext.Produto.Entry(produto).State = EntityState.Modified;
            await _DbContext.SaveChangesAsync();


            return produto;
        }


        [HttpDelete]
        public async Task<ActionResult> Remover(int id)
        {

            var _DbContext = new _DbContext();


            var vProduto = await _DbContext.Produto.FindAsync(id);


            _DbContext.Produto.Remove(vProduto);


            await _DbContext.SaveChangesAsync();

            return Ok();




        }
    }
}
