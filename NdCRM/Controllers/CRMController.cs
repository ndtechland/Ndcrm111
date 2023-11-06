using Microsoft.AspNetCore.Mvc;

namespace NdCRM.Controllers
{
    public class CRMController : Controller
    {
        public IActionResult CustomerRegistration()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult CustomerRegistration(/*CustomerRegistration model*/)
        //{
        //    //try
        //    //{
        //    //    if (ModelState.IsValid)
        //    //    {
        //    //        string resp = ent.CustomerRegistrations(model);
        //    //        TempData["msg"] = resp;
        //    //    }
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    TempData["msg"] = ex.Message;
        //    //}
        //    return View();
        //}
    }
}
