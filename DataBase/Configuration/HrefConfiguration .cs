using DatabaseModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Configuration
{
    class HrefConfiguration : EntityTypeConfiguration<HrefModels>

    {
        public HrefConfiguration()
        {
            HasRequired(m => m.Accordion).WithMany(n => n.Hrefs);
        }

    }
}
