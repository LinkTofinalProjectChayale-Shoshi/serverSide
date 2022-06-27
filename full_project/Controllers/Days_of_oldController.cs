using Bll;
using System;
using System.Web.Http;
using Dto;
namespace full_project.Controllers
{
    public class Days_of_oldController : ApiController
    {
#pragma warning disable IDE0044 // Add readonly modifier
        Days_of_oldbll db = new Days_of_oldbll();
#pragma warning restore IDE0044 // Add readonly modifier
        // GET: api/Days_of_old
        public Object Get()
        {
            db.GetAllDaysOld();
            var res = db.GetAllDaysOld();
            return res.Data;
        }

        // GET: api/Days_of_old/5
        public string Get(int id)
        {
            Seconde s = new Seconde();
            s.TheSecond();
            
            return "value";
        }

        // POST: api/Days_of_old
        public void Post(Days_of_oldDto d)
        {
            db.AddDaysOld(d);
        }
        //[HttpPost]
        //[Route("api/Days_of_old/Login")]
        //public IHttpActionResult Login(ConstraintsoldDto d)
        //{

        //    Days_of_oldDto o = db.Login(ConstraintsoldDto);


        //    if (o == null)
        //        return NotFound();

        //    return Ok(o);
        //}
        // PUT: api/Days_of_old/5
        //public void Put(int id,Days_of_oldDto day)
        //{
        //    db.Update(id, day);
        //}

        // DELETE: api/Days_of_old/5
        public void Delete(int id)
        {
        }
    }
}
