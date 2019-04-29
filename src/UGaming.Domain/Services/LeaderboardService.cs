using System.Collections.Generic;
using UGaming.Domain.Entities;
using UGaming.Domain.Interfaces.Repository;
using UGaming.Domain.Interfaces.Services;

namespace UGaming.Domain.Services
{
    public class LeaderboardService : Service<Leaderboard>, ILeaderboardService
    {
        private readonly ILeaderboardRepository _repositorio;
        public LeaderboardService(ILeaderboardRepository repositorio) : base(repositorio)
        {
            _repositorio = repositorio;
        }

        public IEnumerable<Leaderboard> ObterTop100Desc()
        {
            return _repositorio.ObterTop100Desc();
        }
    }
}
