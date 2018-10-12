using CodeFirstEF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstEF.DAL
{
    public class KontaktyContext : DbContext
    {
        public KontaktyContext() :base("codeFirstConnection")
        {

        }

        public DbSet<Kontakt> Kontakty { get; set; }
    }
}