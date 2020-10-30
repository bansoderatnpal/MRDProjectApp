using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyGitProj.ServiceLayer;
using MyGitProj.ViewModels;
namespace MyGitProj.Controllers
{
    public class MrUserController : Controller
    {
        IAllRepository allRepository = new _IAllRepositoryBusinessLogic();
        
        public ActionResult Index()
        {
            ViewBag.UserList = allRepository.GetAllRegList();

            return View();
        }

       

    }
}