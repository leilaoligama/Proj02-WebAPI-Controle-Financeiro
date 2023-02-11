using ControleFinanceiro.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Business.Interfaces
{
    public interface IReceitaService
    {
        Task Adicionar(Receita receita);
        Task Atualizar(Receita receita);
        Task Remover(int id);
        Task<IEnumerable<Receita>> Detalhar(int id);
    }
}
