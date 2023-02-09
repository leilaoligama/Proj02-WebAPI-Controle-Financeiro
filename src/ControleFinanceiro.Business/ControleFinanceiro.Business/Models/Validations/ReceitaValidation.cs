﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Business.Models.Validations
{

    public class ReceitaValidation : AbstractValidator<Receita>
    {
        public ReceitaValidation()
        {
            RuleFor(c => c.Descricao)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 100).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.Valor)
               .GreaterThan(0).WithMessage("O campo {PropertyName} precisa ser maior que {ComparisonValue}");

            RuleFor(c => c.Data)
            .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
        }
    }
}
