using System.Collections.Generic;
using System.Data;
using UGaming.Domain.Interfaces.Repository;
using UGaming.Domain.Interfaces.Services;

namespace UGaming.Domain.Services
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> _repositorio;

        public Service(IRepository<TEntity> repositorio)
        {
            _repositorio = repositorio;
        }

        public TEntity Adicionar(TEntity entity, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            return _repositorio.Adicionar(entity, transaction, commandTimeout);
        }

        public bool Atualizar(TEntity entity, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            return _repositorio.Atualizar(entity, transaction, commandTimeout);
        }

        public TEntity ObterPorId(long id, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            return _repositorio.ObterPorId(id, transaction, commandTimeout);
        }

        public IEnumerable<TEntity> ObterTodos(IDbTransaction transaction = null, int? commandTimeout = null)
        {
            return _repositorio.ObterTodos(transaction, commandTimeout);
        }

        public IEnumerable<TEntity> ObterPor(object @where = null, object order = null, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            return _repositorio.ObterPor(@where, null, transaction, commandTimeout);
        }

    }
}
