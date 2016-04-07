using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
using System.Threading;

namespace ClubERP.Web.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            DateTime dtNow = DateTime.Now;
            var culture = CultureInfo.CurrentCulture;
            CultureInfo currentUICulture = Thread.CurrentThread.CurrentUICulture;
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            NumberFormatInfo nfiUS = new CultureInfo("en-US", false).NumberFormat;
            NumberFormatInfo nfiFR = new CultureInfo("fr-FR", false).NumberFormat;
            CultureInfo nf = Thread.CurrentThread.CurrentCulture;
            
            return View();
        }
    }
}