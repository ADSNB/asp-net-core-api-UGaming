using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace UGaming.API.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Endpoint GameResult: http://localhost:5000/api/UGaming/GameResult <--- ENDPOINTS ---> Endpoint Leaderboard: http://localhost:5000/api/UGaming/Leaderboard" };
        }
    }
}
