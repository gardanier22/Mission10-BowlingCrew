using BowlingAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace BowlingAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingLeagueController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;

        public BowlingLeagueController(IBowlingRepository temp)
        {
            _bowlingRepository = temp;
        }

        // make it so that the files be able to take the info 

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            return _bowlingRepository.Bowlers.ToArray();

        }

    }
}
