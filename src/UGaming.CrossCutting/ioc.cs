using System.Web.Http;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using UGaming.Application.Interfaces;
using UGaming.Application.Services;
using UGaming.Context;
using UGaming.Context.Interfaces;
using UGaming.Domain.Interfaces.Repository;
using UGaming.Domain.Interfaces.Services;
using UGaming.Domain.Services;
using UGaming.Repository.UGaming;

namespace UGaming.CrossCutting
{
    public class ioc
    {
        public static void Register(Container container)
        {
            container.Register<IUGamingAppService, UGamingAppService>(Lifestyle.Scoped);
            
            container.Register<IGameResultService, GameResultService>(Lifestyle.Scoped);
            container.Register<ILeaderboardService, LeaderboardService>(Lifestyle.Scoped);

            container.Register<IGameResultRepository, GameResultRepository>(Lifestyle.Scoped);
            container.Register<ILeaderboardRepository, LeaderboardRepository>(Lifestyle.Scoped);

            container.Register<IDapperContext, DapperContext>(Lifestyle.Scoped);
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
        }
    }
}
