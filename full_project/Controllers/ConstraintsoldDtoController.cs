using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dto;
using Bll;
using System.Web.Http.Cors;
namespace full_project.Controllers
{
    public class fromreact
    {
        public string Name { get; set; }
    }
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ConstraintsoldDtoController : ApiController
    {
        Constraintsoldbll db = new Constraintsoldbll();
        // GET: api/ConstraintsoldDto
        public Object Get()
        {
            Days_of_oldbll d = new Days_of_oldbll();
            var res = d.GetAllDaysOld();
            List<Days_of_oldDto> lstd = null;
            lstd = (List<Days_of_oldDto>)(res.Data);
            var res2 = db.GetAllConstraintsoldDto();
            List<ConstraintsoldDto> lstcf = null;
            lstcf = (List<ConstraintsoldDto>)(res2.Data);
            oldbll o = new oldbll();
            var res3 = o.GetAllOld();
            List<OldDto> lstf = null;
            lstf = (List<OldDto>)(res3.Data);
            List<AllOld> lw = new List<AllOld>();
            AllOld a ;
            for (int i = 0; i < lstcf.Count(); i++)
            {
                a = new AllOld();
                a.co= lstcf[i];
                a.o = lstf[i];
                a.d = lstd[i];
                lw.Add(a);
            }
            
            return (Object)(lw);
        }

        // GET: api/ConstraintsoldDto/5
        public string Get(int id)
        {
            return "value";
        }
        [HttpPost]
        [Route("api/ConstraintsoldDto/Login")]
        public IHttpActionResult Login(UserDto user)
        {
            long password = user.Password;string mail=user.Name;
            Object o = db.Login(password,mail);
            
            if (o == null)
                return NotFound();
            
            return Ok(o);
        }
        public int returnstatus(int status)
        {
            return status;
        }
        // POST: api/ConstraintsoldDto
        public void Post(AllOld old)
        {
            
            old.co.Level_of_functioningo = old.co.Level_of_functioningo;

           int id= db.AddConstraintsold(old.co);
            oldbll o = new oldbll();
            old.o.conoID = id;
            o.AddOldDto(old.o);
            Days_of_oldbll d = new Days_of_oldbll();
            old.d.conoID = id;
            d.AddDaysOld(old.d);
        }

        // PUT: api/ConstraintsoldDto/5
        public void Put(AllOld o)
        {
             db.Update(o.co);
            Days_of_oldbll d = new Days_of_oldbll();
            d.Update(o.d);
            oldbll old = new oldbll();
            old.Update(o.o);
        }

        // DELETE: api/ConstraintsoldDto/5
        public void Delete(AllOld o)
        {
            db.Deletes(o.co.conoID);
            Days_of_oldbll dy= new Days_of_oldbll();
            dy.Delete(o.d.iddayo);
            oldbll oo = new oldbll();
            oo.Deletes(o.o.idold);
        }
    }
}
