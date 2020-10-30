using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyGitProj.DataAccessLayer;

namespace MyGitProj.ServiceLayer
{
    public class _IAllRepositoryBusinessLogic : IAllRepository
    {
        MrdDBEntities db = new MrdDBEntities();
        public List<UserRegestraion> GetAllRegList()
        {
            List<UserRegestraion> list = db.UserRegestraions.ToList();
            return list;
        }
    }
}