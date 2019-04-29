using System.Collections.Generic;
using UGaming.Domain.Entities;

namespace UGaming.Domain.Interfaces.Services
{
    public interface ILeaderboardService : IService<Leaderboard>
    {
        IEnumerable<Leaderboard> ObterTop100Desc();
    }
}
