using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZMenuManagement;

namespace Zampa.Controllers
{
    public class MenuController : Controller
    {
        [ChildActionOnly]
        public ActionResult _ZampaMenuPartial()
        {
            ZMenuItemManager mgr;
            var injector = new ZMenuXml(Server.MapPath("~/Xml/Menus.xml"));
            mgr = new ZMenuItemManager(injector);
            mgr.Load();
            return PartialView(mgr);
        }
    }
}