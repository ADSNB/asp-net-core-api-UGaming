using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using UGaming.Application.InputModels;
using UGaming.Application.Interfaces;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace UGaming.API.Controllers
{
    [Route("api/[controller]")]
    public class UGamingController : Controller
    {
        private readonly IUGamingAppService _UGAmingAppService;

        public UGamingController(IUGamingAppService ugamingAppService)
        {
            this._UGAmingAppService = ugamingAppService;
        }
        
        [HttpPost]
        [Route("gameresult")]
        public string GameResult([FromBody] GameResultInputModel inputModel)
        {
            if (!ModelState.IsValid)
                return "Verifique os dados de entrada enviados.";

            try
            {
                _UGAmingAppService.GameResultEndPoint(inputModel);
                return "Cadastrado / Atualizado com sucesso!";
            }
            catch (System.Exception ex)
            {
                return "Ocorreu um erro ao atualizar. Descrição do erro: " + ex.Message;
            }
        }
        
        [HttpGet]
        [Route("leaderboard")]
        public IEnumerable<object> LeaderboardEndPoint()
        {
            try
            {
                return _UGAmingAppService.LeaderboardEndPoint();
            }
            catch (System.Exception ex)
            {
                return new string[] { "Ocorreu um erro ao gerar o Top 100. Descrição do erro: " + ex.Message };
            }
        }
    }
}
