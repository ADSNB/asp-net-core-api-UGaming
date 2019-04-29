using UGaming.Domain.Entities;
using UGaming.Domain.Interfaces.Repository;
using UGaming.Domain.Interfaces.Services;

namespace UGaming.Domain.Services
{
    public class GameResultService : Service<GameResult>, IGameResultService
    {
        public GameResultService(IGameResultRepository repositorio) : base (repositorio)
        { }
    }
}
