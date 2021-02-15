using blazor_intro.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazor_intro.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChampionController : ControllerBase
    {
        private readonly ILogger<ChampionController> logger;

        public ChampionController(ILogger<ChampionController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public IEnumerable<Champion> Get()
        {
            List<Champion> champs = new List<Champion>()
            {
                new Champion()
                {
                    Year = 2019,
                    Team = "Toronto Raptors"
                },
                new Champion()
                {
                    Year = 2020,
                    Team = "Los Angeles Lakers"
                },
                new Champion()
                {
                    Year = 2019,
                    Team = "Toronto Raptors"
                },
                new Champion()
                {
                    Year = 2020,
                    Team = "Los Angeles Lakers"
                },
                new Champion()
                {
                    Year = 2019,
                    Team = "Toronto Raptors"
                },
                new Champion()
                {
                    Year = 2020,
                    Team = "Los Angeles Lakers"
                },
                new Champion()
                {
                    Year = 2019,
                    Team = "Toronto Raptors"
                },
                new Champion()
                {
                    Year = 2020,
                    Team = "Los Angeles Lakers"
                },
                new Champion()
                {
                    Year = 2019,
                    Team = "Toronto Raptors"
                },
                new Champion()
                {
                    Year = 2020,
                    Team = "Los Angeles Lakers"
                },
                new Champion()
                {
                    Year = 2019,
                    Team = "Toronto Raptors"
                },
                new Champion()
                {
                    Year = 2020,
                    Team = "Los Angeles Lakers"
                },
                new Champion()
                {
                    Year = 2019,
                    Team = "Toronto Raptors"
                },
                new Champion()
                {
                    Year = 2020,
                    Team = "Los Angeles Lakers"
                },
                new Champion()
                {
                    Year = 2019,
                    Team = "Toronto Raptors"
                },
                new Champion()
                {
                    Year = 2020,
                    Team = "Los Angeles Lakers"
                },
                new Champion()
                {
                    Year = 2019,
                    Team = "Toronto Raptors"
                },
                new Champion()
                {
                    Year = 2020,
                    Team = "Los Angeles Lakers"
                },
                new Champion()
                {
                    Year = 2019,
                    Team = "Toronto Raptors"
                },
                new Champion()
                {
                    Year = 2020,
                    Team = "Los Angeles Lakers"
                },
                new Champion()
                {
                    Year = 2019,
                    Team = "Toronto Raptors"
                },
                new Champion()
                {
                    Year = 2020,
                    Team = "Los Angeles Lakers"
                },
                new Champion()
                {
                    Year = 2019,
                    Team = "Toronto Raptors"
                },
                new Champion()
                {
                    Year = 2020,
                    Team = "Los Angeles Lakers"
                },
                new Champion()
                {
                    Year = 2019,
                    Team = "Toronto Raptors"
                },
                new Champion()
                {
                    Year = 2020,
                    Team = "Los Angeles Lakers"
                },
                new Champion()
                {
                    Year = 2019,
                    Team = "Toronto Raptors"
                },
                new Champion()
                {
                    Year = 2020,
                    Team = "Los Angeles Lakers"
                },
                new Champion()
                {
                    Year = 2019,
                    Team = "Toronto Raptors"
                },
                new Champion()
                {
                    Year = 2020,
                    Team = "Los Angeles Lakers"
                },
                new Champion()
                {
                    Year = 2019,
                    Team = "Toronto Raptors"
                },
                new Champion()
                {
                    Year = 2020,
                    Team = "Los Angeles Lakers"
                },
                new Champion()
                {
                    Year = 2019,
                    Team = "Toronto Raptors"
                },
                new Champion()
                {
                    Year = 2020,
                    Team = "Los Angeles Lakers"
                },
                new Champion()
                {
                    Year = 2019,
                    Team = "Toronto Raptors"
                },
                new Champion()
                {
                    Year = 2020,
                    Team = "Los Angeles Lakers"
                },
                new Champion()
                {
                    Year = 2019,
                    Team = "Toronto Raptors"
                },
                new Champion()
                {
                    Year = 2020,
                    Team = "Los Angeles Lakers"
                },
                new Champion()
                {
                    Year = 2019,
                    Team = "Toronto Raptors"
                },
                new Champion()
                {
                    Year = 2020,
                    Team = "Los Angeles Lakers"
                },
                new Champion()
                {
                    Year = 2019,
                    Team = "Toronto Raptors"
                },
                new Champion()
                {
                    Year = 2020,
                    Team = "Los Angeles Lakers"
                },
                new Champion()
                {
                    Year = 2019,
                    Team = "Toronto Raptors"
                },
                new Champion()
                {
                    Year = 2020,
                    Team = "Los Angeles Lakers"
                },
                new Champion()
                {
                    Year = 2019,
                    Team = "Toronto Raptors"
                },
                new Champion()
                {
                    Year = 2020,
                    Team = "Los Angeles Lakers"
                },
                new Champion()
                {
                    Year = 2019,
                    Team = "Toronto Raptors"
                },
                new Champion()
                {
                    Year = 2020,
                    Team = "Los Angeles Lakers"
                },
                new Champion()
                {
                    Year = 2019,
                    Team = "Toronto Raptors"
                },
                new Champion()
                {
                    Year = 2020,
                    Team = "Los Angeles Lakers"
                },
            };

            return champs.ToArray();
        }
    }
}
