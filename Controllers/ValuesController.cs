using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace pluralsight_concourse_dotnetcore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "pluralsight", "pivotal" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "pluralsight";
        }

        // GET api/values/5/status
        [HttpGet("{id}/status")]
        public string GetCaseStatus(int id)
        {
            if(id > 0 && id <= 10) {
            return "closed";
            }
            else { 
                return "open";
            }
        }

        

    }
}
