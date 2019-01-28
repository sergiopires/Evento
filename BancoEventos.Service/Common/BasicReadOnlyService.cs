using AutoMapper;
using BancoEventos.Domain.Entities.Common;
using BancoEventos.Domain.Repository;
using BancoEventos.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoEventos.Service
{
    public class BasicReadOnlyService<TEntity, TDto, TId, TRepository> : IReadOnlyService<TDto, TId>
       where TEntity : IEntity<TId>
       where TDto : IEntity<TId>
       where TId : IEquatable<TId>
       where TRepository : IReadOnlyRepository<TEntity, TId>
    {
        protected readonly TRepository _repository;
        protected readonly IMapper _engine;

        public BasicReadOnlyService(TRepository repository, IMapper mapperEngine)
        {
            _repository = repository;
            _engine = mapperEngine;
        }

        public TDto Find(TId id)
        {
            TEntity entity = _repository.Get(id);
            TDto mappedEntity = _engine.Map<TEntity, TDto>(entity);

            return mappedEntity;
        }

        public TDto FindAsNoTracking(TId id)
        {
            TEntity entity = _repository.GetWithoutTrack(id);
            TDto mappedEntity = _engine.Map<TEntity, TDto>(entity);

            return mappedEntity;
        }

        public List<TDto> GetAll()
        {
            IEnumerable<TEntity> entities = _repository.All();
            IEnumerable<TDto> mappedEntities = _engine.Map<IEnumerable<TEntity>, IEnumerable<TDto>>(entities);

            return mappedEntities.ToList();
        }
    }
}
