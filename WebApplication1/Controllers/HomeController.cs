using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Bookmarks()
        {
            return View();
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        //[HttpPost]
        //public JsonResult RoleDropDownChanged(string roleId)
        //{

        //    Guid RoleId = new Guid(roleId);

        //    //Some implement

        //    List<string> actions = new List<string>();
        //    for (int i = 0; i <= 10; i++)
        //        actions.Add(i.ToString());

        //    return Json(actions.ToArray(), JsonRequestBehavior.AllowGet);
        //}

        [HttpPost]
        //public JsonResult AddBook(string Name, string imagePath)
        public JsonResult AddBook(Product obj)
        {
            try
            {
                if (Session["Bookmarks"] == null)
                {
                    List<Product> lst = new List<Product>();
                    lst.Add(obj);

                    Session["Bookmarks"] = lst;
                }
                else
                {
                    if (!(Session["Bookmarks"] as List<Product>).Contains(obj))
                    {
                        (Session["Bookmarks"] as List<Product>).Add(obj);
                    }
                }

            }
            catch (Exception ex)
            {

                //throw;
            }
            

            //Session["Bookmarks"] = obj;


            return Json("", JsonRequestBehavior.AllowGet);
        }
    }
}