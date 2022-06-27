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
    public class ConstraintsforeigenworkerController : ApiController
    {
        // GET: api/Constraintsforeigenworker
        Constraintsforeigenworkerbll db = new Constraintsforeigenworkerbll();
        public Object Get()
        {
            
            Daysofworbll d = new Daysofworbll();
            var res=d.GetAllDaysWor();
            List<Days_of_wor2Dto> lstd = null;
            lstd = (List<Days_of_wor2Dto>)(res.Data);
            var res2 = db.GetAllforeigenworker();
            List<ConstraintsforeigenworkerDto> lstcf = null;
            lstcf = (List<ConstraintsforeigenworkerDto>)(res2.Data);
            Foreign_workerbll f = new Foreign_workerbll();
            var res3 = f.GetAllforeign_worer();
            List<Foreign_workerDto> lstf = null;
            lstf = (List<Foreign_workerDto>)(res3.Data);
            List<AllWor> lw = new List<AllWor>();
            AllWor a ;
            for (int i = 0; i < lstcf.Count(); i++)
            {
                a = new AllWor();
                a.co = lstcf[i];
                a.f = lstf[i];
                a.d = lstd[i];
                lw.Add(a);
            }
            return (Object)(lw);
        }

        // GET: api/Constraintsforeigenworker/5
        public string Get(int id)
        {
            return "nnn";
        }

        // POST: api/Constraintsforeigenworker
        public void Post(AllWor wor)
        {
           int id= db.AddConstraintsforeigenworker(wor.co);
            Foreign_workerbll f = new Foreign_workerbll();
            Daysofworbll d = new Daysofworbll();
            wor.f.confid = id;
            wor.d.confid = id;
            f.Addforeign_worer(wor.f);
            d.AddDaysWor(wor.d);
        }
        [HttpPost]
        [Route("api/Constraintsforeigenworker/Login")]
        public IHttpActionResult Login(UserDto user)
        {
            long password = user.Password; 
            string mail = user.Name;
            Object o = db.Login(password, mail);

            if (o == null)
                return NotFound();

            return Ok(o);
        }

        // PUT: api/Constraintsforeigenworker/5
        public void Put(AllWor a)
        {

          //  a.co.confid = 53; a.co.age_of_o = 40; a.co.languagefw = "עברית"; a.co.gender = "בן"; a.co.idcity = 1; a.co.addressfg = null; a.co.Level_of_functioningfg = 3; a.co.money_of_hour = 100; a.co.passwardwor = "s1s2"; a.co.mail="s583294862@gmail.com";
            db.Update(a.co);
            Daysofworbll d = new Daysofworbll();
            d.Update(a.d);
            Foreign_workerbll f = new Foreign_workerbll();
            f.Update(a.f);
        }

        // DELETE: api/Constraintsforeigenworker/5
        public void Delete(AllWor a)
        {
            db.Delete(a.co.confid);
            Daysofworbll d = new Daysofworbll();
            d.Delete(a.d.iddayw);
            Foreign_workerbll f = new Foreign_workerbll();
            f.Delete(a.f.idwor);
        }
    }
}
