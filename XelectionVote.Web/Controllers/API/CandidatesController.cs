using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XelectionVote.Web.Data;

namespace XelectionVote.Web.Controllers.API
{
    [Route("api/[Controller]")]
    public class CandidatesController : Controller
    {
        private readonly ICandidateRepository candidateRepository;

        public CandidatesController(ICandidateRepository candidateRepository)
        {
            this.candidateRepository = candidateRepository;
        }

        [HttpGet]
        public IActionResult GetCandidates()
        {
            return Ok(this.candidateRepository.GetAll());
        }
    }
}
