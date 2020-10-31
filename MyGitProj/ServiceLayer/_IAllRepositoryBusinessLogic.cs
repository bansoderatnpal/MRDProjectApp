using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyGitProj.DataAccessLayer;

namespace MyGitProj.ServiceLayer
{
    public class _IAllRepositoryBusinessLogic : IAllRepository
    {
        public _IAllRepositoryBusinessLogic(int i)
        {

        }
        MrdDBEntities db = new MrdDBEntities();
        public IEnumerable<UserRegestraion> GetAllRegList()
        {
            List<UserRegestraion> list = new List<UserRegestraion>();
            list = db.UserRegestraions.ToList();
            return list;
        }
    }
}