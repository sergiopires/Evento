using System;
using BancoEventos.Domain;
using AutoMapper;
using BancoEventos.Service.Interface;
using BancoEventos.Domain.Entities.Common;
using BancoEventos.Domain.Repository;

namespace BancoEventos.Service.Common
{
    public class BasicWriterService<TEntity, TDto, TId, TRepository> : IWriterService<TDto, TId>
       where TEntity : IEntity<TId>
       where TDto : IEntity<TId>
       where TId : IEquatable<TId>
       where TRepository : IWriterRepository<TEntity, TId>
    {
        protected readonly TRepository _repository;
        protected readonly IMapper _engine;

        public BasicWriterService(TRepository repository, IMapper mapperEngine)
        {
            _repository = repository;
            _engine = mapperEngine;
        }

        public void Create(TDto entity)
        {
            TEntity mappedObject = _engine.Map<TDto, TEntity>(entity);

            _repository.Create(mappedObject);
        }

        public void Delete(TId cod)
        {
            _repository.Delete(cod);
        }

        public void SaveChanges()
        {
            _repository.Save();
        }

        public void Update(TDto entity)
        {
            TEntity mappedEntity = _engine.Map<TDto, TEntity>(entity);
            _repository.Update(mappedEntity);
        }
    }
}
