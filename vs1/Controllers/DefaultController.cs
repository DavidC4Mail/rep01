using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace vs1.Controllers
{
 public class DefaultController : Controller
 {
  // GET: Default
  public ActionResult Index()
  {
   var s;
   return View();
  }
 }
}