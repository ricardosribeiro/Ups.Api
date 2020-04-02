using System;
using System.Collections.Generic;
using System.Text;
using Ups.Business.Notificacoes;

namespace Ups.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
