using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailingListRegistry.Model;

namespace MailingListRegistry.Repository
{
    public class MailingListEntryRepository
    {
        //ideally would have injected this
        private MailingListRegistryContext context = new MailingListRegistryContext();

        public MailingListEntry Get(int id)
        {
            return context.MailingListEntries.Find(id);
        }

        public void Create(MailingListEntry data)
        {
            context.MailingListEntries.Add(data);
            context.SaveChanges();
        }

        public List<MailingListEntry> GetAll()
        {
            return context.MailingListEntries.ToList();
        }

        public List<MailingListEntry> GetWhere(string lastName = null, string sortDir = "asc")
        {
            var data = context.MailingListEntries.AsQueryable();

            if (lastName != null)
                data = data.Where(x => x.LastName == lastName);

            if (sortDir == "asc")
                data = data.OrderBy(x => x.LastName).ThenBy(x => x.FirstName);
            else if (sortDir == "desc")
                data = data.OrderByDescending(x => x.LastName).ThenByDescending(x => x.FirstName);

            return data.ToList();
        }

    }
}
