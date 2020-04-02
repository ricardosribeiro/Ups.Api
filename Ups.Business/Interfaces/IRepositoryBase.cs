using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ups.Business.Entities;

namespace Ups.Business.Interfaces
{
    public interface IRepositoryBase<TEntity>: IDisposable where TEntity: Entity 
    {
        Task<IEnumerable<Imovel>> GetAll();
        Task<Imovel> GetById(Guid id);
        Task<Imovel> Create(TEntity obj);
        Task<Imovel> Update(TEntity obj);
        Task<bool> Remove(Guid id);

    }
}
