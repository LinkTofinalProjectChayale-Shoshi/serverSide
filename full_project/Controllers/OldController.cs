using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Bll;
using Dto;

namespace full_project.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class OldController : ApiController
    {
        oldbll db = new oldbll();
        // GET: api/Old
        public Object Get()
        {
            var res = db.GetAllOld();
            return res.Data;
        }

        // GET: api/Old/5
        public Object Get(int id)
        {
            return "value";
        }
        [HttpPost]
        [Route("api/Old/Login")]
        public IHttpActionResult Login(ConstraintsoldDto ido)
        {



            OldDto o = db.Login(ido);


            if (o == null)
                return NotFound();

            return Ok(o);
        }

        // POST: api/Old
        public void Post(OldDto o)
        {
            db.AddOldDto(o);
        }

        // PUT: api/Old/5
        //public void Put(int id, OldDto o)
        //{
        //    db.Update(id, o);
        //}

        // DELETE: api/Old/5
        public void Delete(int id)
        {
            db.Deletes(id);
        }
    }
}

