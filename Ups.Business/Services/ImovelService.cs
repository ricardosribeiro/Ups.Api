using System;
using System.Threading.Tasks;
using Ups.Business.Entities;
using Ups.Business.Entities.Validacoes;
using Ups.Business.Interfaces;

namespace Ups.Business.Services
{
    public class ImovelService : ServiceBase, IImovelService
    {

        public ImovelService(INotificador notificador):base(notificador)
        {
        }
        public async Task<Imovel> Adicionar(Imovel imovel)
        {
            if (ExecutarValidacao(new ImovelValidation(), imovel)) return false;

            //Faz  outras validades como consistência com o banco de dados

            //Faz a persistência

            return true;
        }

        public Task<Imovel> Atualizar(Imovel imovel)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
