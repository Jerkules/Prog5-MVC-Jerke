using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OefeningMVC.Models
{
    public class componentContext: DbContext
    {
        public DbSet<component> Componenten { get; set; }

        public componentContext()
        {

            Database.SetInitializer<componentContext>(new componentInitializer());

        }
    }
}