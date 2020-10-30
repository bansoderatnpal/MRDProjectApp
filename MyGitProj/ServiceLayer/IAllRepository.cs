using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGitProj.DataAccessLayer;
namespace MyGitProj.ServiceLayer
{
    interface IAllRepository
    {
        List<UserRegestraion> GetAllRegList();

    }
}
