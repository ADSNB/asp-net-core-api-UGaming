using System.Collections.Generic;
using System.Linq;
using DapperExtensions;
using System.Data;
using UGaming.Context.Interfaces;
using UGaming.Domain.Entities;
using UGaming.Domain.Interfaces.Repository;

namespace UGaming.Repository.UGaming
{
    public class GameResultRepository : Repository<GameResult>, IGameResultRepository
    {
        private IDapperContext _context;

        public GameResultRepository(IDapperContext context)
            : base (context)
        {
            _context = context;
        }
    }
}
