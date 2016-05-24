using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OefeningMVC.Models
{
    public class component
    {
        public int Id { get; set; }
        public string Naam { get; set; } 
        public string Categorie { get; set; }
        public string Link { get; set; }
        public int aantal { get; set; }
        public double Aankoopprijs { get; set; }
    }
}