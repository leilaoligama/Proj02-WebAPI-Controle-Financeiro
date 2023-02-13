using ControleFinanceiro.Business.Models;
using ControleFinanceiro.Data.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReceitaController : ControllerBase
    {
        private readonly MeuDbContext _dbContext;

        public ReceitaController(MeuDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IEnumerable<Receita>> ObterRceitas()
        {
            return await _dbContext.Receitas.ToListAsync();

        }

        [HttpPost]
        public async Task<ActionResult<Receita>> Adicionar(Receita receita)
        {
            await _dbContext.Receitas.AddAsync(receita);
            _dbContext.SaveChanges();
            return Ok();
        }

    }
}
