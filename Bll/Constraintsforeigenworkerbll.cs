using Dal;
using Dto;
using System.Collections.Generic;
using System.Linq;

namespace Bll
{
    public class Constraintsforeigenworkerbll
    {
        public RequestResult GetAllforeigenworker()
        {
            
            
            using (dbEntities db = new dbEntities())
            {
                List<ConstraintsforeigenworkerDto> lst = new List<ConstraintsforeigenworkerDto>();
                foreach (var item in db.Constraintsforeigenworker.ToList()) {
                   
                    lst.Add(ConstraintsforeigenworkerDto.DalToDto(item));
                    
                 }

                
                
                return new RequestResult()
                {
                    Data = lst,
                    Message = "succesfull",
                    status = true
                };
            }
        }
        public int AddConstraintsforeigenworker(ConstraintsforeigenworkerDto cw)
        {
            int id;
            using (dbEntities db = new dbEntities())
            {
                db.Constraintsforeigenworker.Add(cw.DtoToDal());
                db.SaveChanges();
               cw=  ConstraintsforeigenworkerDto.DalToDto( db.Constraintsforeigenworker.FirstOrDefault(user=>user.mail==cw.mail));
                    
                id = cw.confid;
            }
            return id;
        }
        public void Update(ConstraintsforeigenworkerDto w)
        {
            using (dbEntities db = new dbEntities())
            {

                foreach (Constraintsforeigenworker wor in db.Constraintsforeigenworker)

                {
                    if (wor.confid == w.confid)
                    {
                        wor.age_of_o = w.age_of_o;
                        wor.addressfg = w.addressfg;
                        wor.gender = w.gender;
                        wor.idcity = w.idcity;
                        wor.languagefw = w.languagefw;
                        wor.Level_of_functioningfg = w.Level_of_functioningfg;
                        wor.mail = w.mail;
                        wor.passwardwor = w.passwardwor;
                    }

                }
                db.SaveChanges();

            }
        }
        public AllWor Login(long password, string mail)
        {
            using (dbEntities db = new dbEntities())
            {
                ConstraintsforeigenworkerDto co = ConstraintsforeigenworkerDto.DalToDto(db.Constraintsforeigenworker.FirstOrDefault(c => c.passwardwor .Equals( password) && c.mail == mail));
                Foreign_workerDto f = Foreign_workerDto.DalToDto(db.Foreign_worker.FirstOrDefault(c => c.confid == co.confid));
                Days_of_wor2Dto d = Days_of_wor2Dto.DalToDto(db.days_of_wor2.FirstOrDefault(c => c.confid == co.confid));
                AllWor a = new AllWor();
                a.co = co;
                a.f = f;
                a.d = d;
                return a;

            }
        }
        public void Delete(int idwor)
        {
            using (dbEntities db = new dbEntities())
            {

                foreach (Constraintsforeigenworker wor in db.Constraintsforeigenworker)

                {
                    if (wor.confid == idwor)
                    {
                        db.Constraintsforeigenworker.Remove(wor);
                    }

                }
                db.SaveChanges();

            }
        }
    }
}
