using BancoEventos.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoEventos.Service.Interface
{
    public interface IService<TDto, TId>
     where TDto : IEntity<TId>
     where TId : IEquatable<TId>
    {
        TDto Find(TId id);

        List<TDto> GetAll();

        TDto FindAsNoTracking(TId id);

        void Create(TDto entity);

        void SaveChanges();

        void Update(TDto entity);

        void Delete(TId cod);
    }
}
