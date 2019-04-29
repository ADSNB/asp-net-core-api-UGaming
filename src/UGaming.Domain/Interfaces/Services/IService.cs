using System.Collections.Generic;
using System.Data;

namespace UGaming.Domain.Interfaces.Services
{
    public interface IService<TEntity> where TEntity : class
    {
        TEntity Adicionar(TEntity entity, IDbTransaction transaction = null, int? commandTimeout = null);
        bool Atualizar(TEntity entity, IDbTransaction transaction = null, int? commandTimeout = null);
        TEntity ObterPorId(long id, IDbTransaction transaction = null, int? commandTimeout = null);
        IEnumerable<TEntity> ObterTodos(IDbTransaction transaction = null, int? commandTimeout = null);
        IEnumerable<TEntity> ObterPor(object where = null, object order = null, IDbTransaction transaction = null, int? commandTimeout = null);
    }
}
