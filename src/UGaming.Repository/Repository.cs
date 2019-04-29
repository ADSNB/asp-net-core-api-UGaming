using System;
using System.Collections.Generic;
using System.Data;
using UGaming.Domain.Interfaces.Repository;
using UGaming.Context.Interfaces;
using UGaming.Context.Mapping;
using DapperExtensions;
using DapperExtensions.Sql;

namespace UGaming.Repository
{
    public class Repository<TEntity> : IRepository<TEntity>, IDisposable where TEntity : class
    {
        public IDbConnection Conn { get; set; }

        public Repository(IDapperContext context)
        {
            Conn = context.Connection;
            InicializaMapperDapper();
        }

        public static void InicializaMapperDapper()
        {
            DapperExtensions.DapperExtensions.SetMappingAssemblies(new[] {
                typeof(GameResultMapper).Assembly,
                typeof(LeaderboardMapper).Assembly
            });
            DapperExtensions.DapperExtensions.SqlDialect = new PostgreSqlDialect();
        }

        public TEntity Adicionar(TEntity entity, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            return ObterPorId(Conn.Insert(entity, transaction, commandTimeout));
        }

        public bool Atualizar(TEntity entity, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            return entity != null && Conn.Update(entity, transaction, commandTimeout);
        }

        public TEntity ObterPorId(long id, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            return Conn.Get<TEntity>(id, transaction, commandTimeout); ;
        }

        public IEnumerable<TEntity> ObterTodos(IDbTransaction transaction = null, int? commandTimeout = null)
        {
            return Conn.GetList<TEntity>(null, null, transaction, commandTimeout);
        }

        public IEnumerable<TEntity> ObterPor(object @where = null, object order = null, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            return Conn.GetList<TEntity>(@where);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
