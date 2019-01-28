﻿using BancoEventos.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BancoEventos.Domain.Repository
{
    public interface IRepository<TEntity, TId>
          where TEntity : IEntity<TId>
          where TId : IEquatable<TId>
    {
        TEntity Get(TId id);
        TEntity GetWithoutTrack(TId id);
        TEntity GetWithoutTrack(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> All();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(TId id);
        void Save();
    }
}
