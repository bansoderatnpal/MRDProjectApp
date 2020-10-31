using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyGitProj.ServiceLayer;
using MyGitProj.ViewModels;
using MyGitProj.DataAccessLayer;
namespace MyGitProj.Controllers
{
    public class MrUserController : Controller
    {
        IAllRepository allRepository; 
        public MrUserController(IAllRepository _allRepository)
        {
            allRepository = _allRepository;
        }
        public JsonResult GetCityList(int StateId)
        {
            MrdDBEntities db = new MrdDBEntities();
            db.Configuration.ProxyCreationEnabled = false;
            List<Citie_table> listCity = db.Citie_table.Where(x => x.States == StateId).ToList();
            return Json(listCity, JsonRequestBehavior.AllowGet);
        }

        private void CityList()
        {
            MrdDBEntities db = new MrdDBEntities();
            List<State_table> Statelist = db.State_table.ToList();
            ViewBag.StateList = new SelectList(Statelist, "StateId", "StateName");
        }

        public ActionResult Index()
        {
                  IEnumerable<UserRegestraion> UserList = allRepository.GetAllRegList();
                  return View(UserList);
        }
    }
}