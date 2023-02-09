using ControleFinanceiro.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Business.Services
{
    public class ReceitaService
    {
        private readonly IReceitaService _receitaService;

        public ReceitaService(IReceitaService receitaService)
        {
            _receitaService = receitaService;
        }

    }
}
