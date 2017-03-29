using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace mtapi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values?searchField
        [HttpGet]
        public IEnumerable<Result> Get(string searchField = null)
        {
            // судя по заданию, неважно какое value, поэтому просто GUID
            return 
            searchField?
                .Split(new[]{" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => new Result(x, Guid.NewGuid().ToString()) ) 
            ?? new List<Result>(); 
        }
    }
}
