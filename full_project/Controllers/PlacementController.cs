using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Bll;


namespace full_project.Controllers
{

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PlacementController : ApiController
    {
        Placementbll p = new Placementbll();
        Seconde s = new Seconde();
        // GET: api/Placement
        [HttpGet]
        [Route("api/Placement/Function")]
        public IHttpActionResult Placement()
        {
            s.TheSecond();
            return Ok();
        }
        [HttpGet]
        [Route("api/Placement")]
        public Object Get()
        {
            var res = p.GetAllplacement();
            return res.Data;
            //return new string[] { "value1", "value2" };
        }


        // GET: api/Placement/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Placement
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Placement/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Placement/5
        public void Delete(int id)
        {
        }
    }
}
