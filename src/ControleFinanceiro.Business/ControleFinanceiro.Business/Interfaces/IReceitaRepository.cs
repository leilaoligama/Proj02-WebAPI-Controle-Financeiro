using ControleFinanceiro.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Business.Interfaces
{
    public interface IReceitaRepository
    {
        Task<IEnumerable<Receita>> ObterReceitas();
        Task<Receita> ObterReceitaPorId(int id);
    }
}
