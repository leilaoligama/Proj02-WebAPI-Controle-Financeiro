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
        Task Adicionar(Receita receita) { return Task.CompletedTask; }
        Task Atualizar(Receita receita) { return Task.CompletedTask; }
        Task Remover(int id) { return Task.CompletedTask; }
    }
}
