using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OefeningMVC.Models
{
    public class CategorieContext: DbContext
    {
        public DbSet<Categorie> Categories { get; set; }

        public CategorieContext()
        {

            Database.SetInitializer<CategorieContext>(new CategorieInitializer());

        }
    }
}