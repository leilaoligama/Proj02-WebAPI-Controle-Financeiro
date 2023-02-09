using ControleFinanceiro.Business.Interfaces;
using ControleFinanceiro.Business.Models;
using ControleFinanceiro.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Data.Repository
{
    public class ReceitaRepository : IReceitaRepository
    {
        protected readonly MeuDbContext _dbContext;

        public ReceitaRepository(MeuDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Receita> ObterReceitaPorId(int id)
        {
            return await _dbContext.Receitas.FirstOrDefaultAsync(x => x.ReceitaId == id);
        }

        public async Task<IEnumerable<Receita>> ObterReceitas()
        {
            return await _dbContext.Receitas.OrderBy(x => x.Data).ToListAsync();
        }
    }
}
