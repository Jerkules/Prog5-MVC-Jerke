using System.Data.Entity;

namespace OefeningMVC.Models
{
    class componentInitializer : DropCreateDatabaseAlways<componentContext>
    {
        protected override void Seed(componentContext context)
        {
            base.Seed(context);


            component a = new component()
            {
                Naam = "25c65d8",
                Categorie = "Halfgeleider",
                aantal = 25,
                Aankoopprijs = 0.25
            };
            component b = new component()
            {
                Naam = "D25C85",
                Categorie = "Schakelaar",
                aantal = 256,
                Aankoopprijs = 1.85
            };
            component c = new component()
            {
                Naam = "C3P0",
                Categorie = "Robottechnologie",
                aantal = 31,
                Aankoopprijs = 200.51
            };
            component d = new component()
            {
                Naam = "R2D2",
                Categorie = "Robottechnologie",
                aantal = 25,
                Aankoopprijs = 156.25
                
            };
            context.Componenten.Add(a);
            context.Componenten.Add(b);
            context.Componenten.Add(c);
            context.Componenten.Add(d);
            context.SaveChanges();

        }

    }
}