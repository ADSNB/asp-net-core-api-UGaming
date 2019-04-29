using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UGaming.Application.InputModels;

namespace UGaming.Application.Interfaces
{
    public interface IUGamingAppService
    {
        void GameResultEndPoint(GameResultInputModel inputModel);
        IEnumerable<Object> LeaderboardEndPoint();
    }
}
