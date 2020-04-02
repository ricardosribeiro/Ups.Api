using System;
using System.Threading.Tasks;
using Ups.Business.Entities;

namespace Ups.Business.Interfaces
{
    public interface IImovelService: IDisposable
    {
        Task<Imovel> Adicionar(Imovel imovel);
        Task<Imovel> Atualizar(Imovel imovel);
        Task<bool> Remover(Guid id);
    }
}
