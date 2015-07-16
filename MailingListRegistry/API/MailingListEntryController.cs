using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MailingListRegistry.Repository;
using MailingListRegistry.Model;

namespace MailingListRegistry.API
{
    public class MailingListEntryController : ApiController
    {
        // GET: api/MailingListEntry
        public IEnumerable<MailingListEntry> Get(string lastName = null, string sortDir = "asc")
        {
            //ideally would have injected this
            var repo = new MailingListEntryRepository();
            return repo.GetWhere(lastName, sortDir);
        }
    }
}
