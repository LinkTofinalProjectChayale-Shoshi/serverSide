using Bll;
using System;
using System.Web.Http;
using System.Web.Http.Cors;
namespace full_project.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CityesController : ApiController
    {
#pragma warning disable IDE0044 // Add readonly modifier
        citybll db = new citybll();
#pragma warning restore IDE0044 // Add readonly modifier
        // GET: api/cityes
        //הוספה
        public Object Get()
        {
            
            
            db.GetAllCity();
            var res = db.GetAllCity();

            return res.Data;
        }

        // GET: api/cityes/5
        //שליפה לפי ה-שם משפחה+שם פרטי
        public string Get(string fname, string lname)
        {
            Seconde s = new Seconde();
            s.TheSecond();
            
            return "value";
        }
        // הוספה מהריאקט
        // POST: api/cityes
        public void Post([FromBody] string value)
        {
            
        }
        //הוספת נתונים למשתמש קיים
        // PUT: api/cityes/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/cityes/5
        public void Delete(int id)
        {
        }
    }
}
