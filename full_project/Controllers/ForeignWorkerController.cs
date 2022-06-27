using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bll;
using Dto;
namespace full_project.Controllers
{
    public class ForeignWorkerController : ApiController
    {
        Foreign_workerbll db = new Foreign_workerbll();
        // GET: api/ForeignWorker
        public Object Get()
        {
            var res = db.GetAllforeign_worer();
            return res.Data;
        }

        // GET: api/ForeignWorker/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ForeignWorker
        public void Post(Foreign_workerDto f)
        {
            db.Addforeign_worer(f);

        }
  
        
        
        [HttpPost]
        [Route("api/ForeignWorker/Login")]
        public IHttpActionResult Login(ConstraintsforeigenworkerDto ido)
        {

            Foreign_workerDto o = db.Login(ido);


            if (o == null)
                return NotFound();

            return Ok(o);
        }

        // PUT: api/ForeignWorker/5
        //public void Put(int id, Foreign_workerDto f)
        //{
        //    db.Update(id,f);
        //}

        // DELETE: api/ForeignWorker/5
        public void Delete(int id)
        {
            db.Delete(id);
        }
    }
}
