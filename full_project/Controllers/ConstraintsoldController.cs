using Bll;
using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace full_project.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ConstraintsoldDtoController : ApiController
    {
#pragma warning disable IDE0044 // Add readonly modifier
        Constraintsoldbll db = new Constraintsoldbll();
#pragma warning restore IDE0044 // Add readonly modifier
        // GET: api/ConstraintsoldDto
        public Object Get()
        {
            var res = db.GetAllConstraintsoldDto();
            return res.Data;
        }

        // GET: api/ConstraintsoldDto/5
        public string Get(int id)
        {
            Seconde s = new Seconde();
            s.TheSecond();
            return "value";
        }
        [HttpPost]
        [Route("api/ConstraintsoldDto/Login")]
        public IHttpActionResult Login(UserDto u)
        {
            object co = Userbll.Login(u);
            if (co == null)
                return NotFound();
            return Ok(co);

            
        }
        // POST: api/ConstraintsoldDto
        public bool Post(ConstraintsoldDto c)
        {
            db.AddConstraintsoldDto(c);
            return true;
        }

        // PUT: api/ConstraintsoldDto/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ConstraintsoldDto/5
        public void Delete(int id)
        {
        }
    }
}
