using System;
using System.Collections.Generic;
using System.Text;
using Ups.Business.Interfaces;

namespace Ups.Business.Services
{
    public class ServiceBase
    {
        private readonly INotificador _notificador;

        public ServiceBase(INotificador notificador)
        {
            _notificador = notificador;
        }


    }
}
