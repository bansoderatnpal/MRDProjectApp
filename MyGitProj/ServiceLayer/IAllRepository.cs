using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGitProj.DataAccessLayer;
namespace MyGitProj.ServiceLayer
{
    public interface IAllRepository
    {
        IEnumerable<UserRegestraion> GetAllRegList();

    }
}
