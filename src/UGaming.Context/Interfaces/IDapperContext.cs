using System;
using System.Data;

namespace UGaming.Context.Interfaces
{
    public interface IDapperContext : IDisposable
    {
        IDbConnection Connection { get; }
    }
}
