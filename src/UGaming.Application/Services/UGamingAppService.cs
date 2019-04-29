using System.Collections.Generic;
using System.Linq;
using UGaming.Application.InputModels;
using UGaming.Application.Interfaces;
using UGaming.Context.Interfaces;
using UGaming.Domain.Entities;
using UGaming.Domain.Interfaces.Services;

namespace UGaming.Application.Services
{
    public class UGamingAppService : IUGamingAppService
    {
        private readonly IGameResultService _gameResultService;
        private readonly ILeaderboardService _LeaderboardService;
        private readonly IUnitOfWork _uow;

        public UGamingAppService(IGameResultService gamersvc, ILeaderboardService leaderboardsvc , IUnitOfWork uow)
        {
            this._gameResultService = gamersvc;
            this._LeaderboardService = leaderboardsvc;
            this._uow = uow;
        }

        public void GameResultEndPoint(GameResultInputModel inputModel)
        {
            try
            {
                CriarDadosJogo(inputModel);
                
                var leaderBoard = ExisteRegistroLeaderboard(inputModel);
                
                if (leaderBoard != null)
                    AtualizaRegistroLeaderboard(inputModel, leaderBoard);
                else
                    CriaRegistroLeaderboard(inputModel);

                _uow.Commit();
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        public IEnumerable<object> LeaderboardEndPoint()
        {
            return _LeaderboardService.ObterTop100Desc();
        }

        #region Private Functions

        private void CriarDadosJogo(GameResultInputModel inputModel)
        {
            var gameResult = GameResult.Factory.New(inputModel.GameId.Value, inputModel.PlayerId.Value, inputModel.Win.Value, inputModel.TimeStamp.Value);
            _gameResultService.Adicionar(gameResult, _uow.BeginTransaction());
        }

        private Leaderboard ExisteRegistroLeaderboard(GameResultInputModel inputModel)
        {
            return _LeaderboardService.ObterPorId(inputModel.PlayerId.Value);
        }

        private void AtualizaRegistroLeaderboard(GameResultInputModel inputModel, Leaderboard leaderboard)
        {
            leaderboard.AtualizaBalance(inputModel.Win.Value, inputModel.TimeStamp.Value);
            _LeaderboardService.Atualizar(leaderboard, _uow.BeginTransaction());
        }

        private void CriaRegistroLeaderboard(GameResultInputModel inputModel)
        {
            var leaderboard = Leaderboard.Factory.New(inputModel.PlayerId.Value, inputModel.Win.Value, inputModel.TimeStamp.Value);
            _LeaderboardService.Adicionar(leaderboard, _uow.BeginTransaction());
        }

        #endregion
    }
}