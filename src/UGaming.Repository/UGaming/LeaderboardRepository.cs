using System.Linq;
using UGaming.Domain.Entities;
using UGaming.Context.Interfaces;
using UGaming.Domain.Interfaces.Repository;
using System.Collections;
using System.Data;
using DapperExtensions;
using System.Collections.Generic;

namespace UGaming.Repository.UGaming
{
    public class LeaderboardRepository : Repository<Leaderboard>, ILeaderboardRepository
    {
        private IDapperContext _context;

        public LeaderboardRepository(IDapperContext context)
            : base (context)
        {
            _context = context;
        }

        public IEnumerable<Leaderboard> ObterTop100Desc()
        {
            List<ISort> ordenacao = new List<ISort>();
            ordenacao.Add(Predicates.Sort<Leaderboard>(lead => lead.Balance, false));
            return Conn.GetSet<Leaderboard>(null, ordenacao, 0, 100);
        }
    }
}
