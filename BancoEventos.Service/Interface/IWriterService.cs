using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoEventos.Domain.Entities.Common;

namespace BancoEventos.Service.Interface
{
    public interface IWriterService<TDto, TId>
       where TDto : IEntity<TId>
       where TId : IEquatable<TId>
    {
        void Create(TDto entity);

        void SaveChanges();

        void Update(TDto entity);

        void Delete(TId cod);
    }
}
