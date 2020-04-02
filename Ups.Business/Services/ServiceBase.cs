using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using Ups.Business.Entities;
using Ups.Business.Interfaces;
using Ups.Business.Notificacoes;

namespace Ups.Business.Services
{
    public abstract class ServiceBase
    {
        private readonly INotificador _notificador;

        protected ServiceBase(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected void Notificar(ValidationResult validationResult)
        {
            foreach (var erro in validationResult.Errors)
            {
                Notificar(erro.ErrorMessage);
            }
        }

        protected void Notificar(string mensagem)
        {
            _notificador.Handle(new Notificacao(mensagem));
        }

        protected bool ExecutarValidacao<TV,TE>(TV validacao, TE entidade) where TV: AbstractValidator<TE> where TE: Entity
        {
            var validator = validacao.Validate(entidade);

            if (validator.IsValid) return true;

            Notificar(validator);
            return false;
        }


    }
}
