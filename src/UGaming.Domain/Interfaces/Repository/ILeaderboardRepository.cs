using System.Collections.Generic;
using System.Data;
using UGaming.Domain.Entities;

namespace UGaming.Domain.Interfaces.Repository
{
    public interface ILeaderboardRepository : IRepository<Leaderboard>
    {
        IEnumerable<Leaderboard> ObterTop100Desc();
    }
}
