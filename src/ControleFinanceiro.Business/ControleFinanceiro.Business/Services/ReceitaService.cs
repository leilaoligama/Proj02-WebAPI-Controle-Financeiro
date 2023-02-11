using ControleFinanceiro.Business.Interfaces;
using ControleFinanceiro.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Business.Services
{
    public class ReceitaService : IReceitaService
    {
        private readonly IReceitaService _receitaService;

        public ReceitaService(IReceitaService receitaService)
        {
            _receitaService = receitaService;
        }

        public Task Adicionar(Receita receita)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(Receita receita)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Receita>> Detalhar(int id)
        {
            throw new NotImplementedException();
        }

        public Task Remover(int id)
        {
            throw new NotImplementedException();
        }
    }
}
