using Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace full_project.Controllers
{
    public class Foreign_workerDtoController : ApiController
    {
#pragma warning disable IDE0044 // Add readonly modifier
        Foreign_workerbll db = new Foreign_workerbll();
#pragma warning restore IDE0044 // Add readonly modifier
        // GET: api/Foreign_workerDto
        public Object Get()
        {
            var res = db.GetAllforeign_worer();
            return res.Data;
        }

        // GET: api/Foreign_workerDto/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Foreign_workerDto
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Foreign_workerDto/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Foreign_workerDto/5
        public void Delete(int id)
        {
        }
    }
}
