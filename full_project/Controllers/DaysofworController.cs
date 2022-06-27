using Bll;
using System;
using System.Web.Http;
using Dto;
namespace full_project.Controllers
{
    public class DaysofworController : ApiController
    {
        //#pragma warning disable IDE0044 // Add readonly modifier
        Daysofworbll db = new Daysofworbll();
        //#pragma warning restore IDE0044 // Add readonly modifier
        // GET: api/Daysofwor
        public Object Get()
        {
            var res = db.GetAllDaysWor();
            return res.Data;
        }

        // GET: api/Daysofwor/5
        public string Get(int id)
        {
            Seconde s = new Seconde();
            s.TheSecond();
            return "value";
        }

        // POST: api/Daysofwor
        public void Post(Days_of_wor2Dto d)
        {
            db.AddDaysWor(d);
        }
        [HttpPost]
        [Route("api/Daysofwor/Login")]
        public IHttpActionResult Login(ConstraintsforeigenworkerDto ido)
        {

            Days_of_wor2Dto o = db.Login(ido);


            if (o == null)
                return NotFound();

            return Ok(o);
        }
        // PUT: api/Daysofwor/5
        //public void Put(int id, Days_of_wor2Dto day)
        //{
        //    db.Update(id, day);
        //}

        // DELETE: api/Daysofwor/5
        public void Delete(int id)
        {
        }
    }
}
