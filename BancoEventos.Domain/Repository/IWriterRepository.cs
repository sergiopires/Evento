using BancoEventos.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoEventos.Domain.Repository
{
    public interface IWriterRepository<TEntity, TId>
          where TEntity : IEntity<TId>
          where TId : IEquatable<TId>
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(TId id);
        void Save();
    }
}
