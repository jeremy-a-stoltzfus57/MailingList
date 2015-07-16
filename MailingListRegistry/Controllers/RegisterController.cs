using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MailingListRegistry.Repository;
using MailingListRegistry.Model;

namespace MailingListRegistry.Controllers
{
    public class RegisterController : Controller
    {

        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(MailingListEntry entry)
        {
            if(ModelState.IsValid)
            { 
                //ideally would have injected this object via ninject
                var repo = new MailingListEntryRepository();
                repo.Create(entry);
                return View("Confirm", entry);
            }

            return View(entry);
        }
    }
}
