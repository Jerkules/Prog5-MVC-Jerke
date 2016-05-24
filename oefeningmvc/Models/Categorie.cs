using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OefeningMVC.Models
{
    public class Categorie
    {
        public int ID { get; set; }
        public string CategorieNaam { get; set; }

        public Categorie()
        { 
        }
        public Categorie(string naam)
        {
            this.CategorieNaam = naam;
        }
    }
}