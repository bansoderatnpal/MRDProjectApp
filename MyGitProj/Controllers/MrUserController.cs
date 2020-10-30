using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyGitProj.DAL;
using MyGitProj.ServiceLayer;
using MyGitProj.ViewModels;

namespace MyGitProj.Controllers
{
    public class MrUserController : Controller
    {

        private IAllRepositoryImplimantaion<UserRegestraion> userReg;
        private IAllRepositoryImplimantaion<State> state;
        private IAllRepositoryImplimantaion<City> city;

        public MrUserController()
        {
            userReg = new IAllRepositoryImplimantaion<UserRegestraion>();
            state = new IAllRepositoryImplimantaion<State>();
            city = new IAllRepositoryImplimantaion<City>();
        }
        
        // GET: MrUser
        public ActionResult Index()
        {
            return View(userReg.GetModel());
        }

        [HttpGet]
        public ActionResult UserReg()
        {
            List<State> statelist = state.GetModel().ToList();
            ViewBag.Slist = new SelectList(statelist, "StateID", "StateName");
            List<City> citylist = city.GetModel().ToList();
            ViewBag.Clist = new SelectList(citylist, "CityID", "CityName");
            return View();
        }

        [HttpPost]
        public ActionResult UserReg(UserRegestraion userRegestraion)
        {
            userReg.InsertModel(userRegestraion);
            userReg.Save();
            return RedirectToAction("Index");
        }

    }
}