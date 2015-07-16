using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MailingListRegistry.Repository
{
    public class MailingListRegistryContext : DbContext
    {
    
        public MailingListRegistryContext() : base("name=MailingListRegistryContext")
        {
        }

        public System.Data.Entity.DbSet<MailingListRegistry.Model.MailingListEntry> MailingListEntries { get; set; }
    
    }
}
