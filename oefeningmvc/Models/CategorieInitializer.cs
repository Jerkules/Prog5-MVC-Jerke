using System.Data.Entity;

namespace OefeningMVC.Models
{
    internal class CategorieInitializer : DropCreateDatabaseAlways<CategorieContext>
    {
        protected override void Seed(CategorieContext context)
        {
            base.Seed(context);


            Categorie a = new Categorie()
            {
                CategorieNaam = "Halfgeleider"
            };
            Categorie b = new Categorie()
            {
                CategorieNaam = "Robots"
            };
            context.Categories.Add(a);
            context.Categories.Add(b);
            context.SaveChanges();

        }

    }
}